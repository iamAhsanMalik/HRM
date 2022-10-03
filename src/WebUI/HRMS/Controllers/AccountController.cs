using HRMS.Models;

namespace HRMS.Controllers;

[Authorize]
public class AccountController : Controller
{
    private readonly IEmailService _emailService;
    private readonly IFileHelpers _fileHelpers;
    private readonly IAuthService _authService;
    private readonly IMapper _mapper;
    private readonly IUserInfo _userInfo;

    public AccountController(IEmailService emailService, IFileHelpers fileHelpers, IAuthService authService, IMapper mapper, IUserInfo userInfo)
    {
        _emailService = emailService;
        _fileHelpers = fileHelpers;
        _authService = authService;
        _mapper = mapper;
        _userInfo = userInfo;
    }

    #region  Login
    //
    // GET: /Account/Login
    [HttpGet, AllowAnonymous]
    public IActionResult Login(string? returnUrl = null)
    {
        ViewData["ReturnUrl"] = returnUrl;
        return View();
    }

    //
    // POST: /Account/Login
    [HttpPost, AllowAnonymous, ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(LoginDTO model, string? returnUrl = null)
    {
        returnUrl ??= Url.Content("/");

        ViewData["ReturnUrl"] = returnUrl;
        if (ModelState.IsValid)
        {
            // To enable password failures to trigger account lockout, set lockoutOnFailure: true
            var signInResult = await _authService.PasswordLoginAsync(model, false);

            if (signInResult?.Succeeded == true)
            {
                return RedirectToLocal(returnUrl);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return View(model);
            }
        }
        // If we got this far, something failed, redisplay form
        return View(model);
    }
    #endregion

    #region Register
    //
    // GET: /Account/Register
    [HttpGet, AllowAnonymous]
    public IActionResult Register(string? returnUrl = null)
    {
        ViewData["ReturnUrl"] = returnUrl;
        return View();
    }

    //
    // POST: /Account/Register
    [HttpPost, AllowAnonymous, ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(RegisterDTO model, string? returnUrl = null)
    {
        if (ModelState.IsValid)
        {
            returnUrl ??= Url.Content(contentPath: "/");
            ViewData["ReturnUrl"] = returnUrl;
            var applicationUser = _mapper.Map<ApplicationUser>(model);
            var registerResult = await _authService.RegisterWithPasswordAsync(model);

            if (registerResult?.Succeeded == true)
            {
                return RedirectToLocal(returnUrl);
            }
            AddErrors(registerResult);
        }

        // If we got this far, something failed, redisplay form
        return View(model);
    }

    #endregion

    #region Logout

    //
    // POST: /Account/Logout
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Logout()
    {
        await _authService.LogoutAsync();
        return RedirectToAction("Index", "Home");
    }
    #endregion

    #region ConfirmEmail
    // GET: /Account/ConfirmEmail
    [HttpGet, AllowAnonymous]
    public async Task<IActionResult> ConfirmEmail(string userId, string code)
    {
        if (userId == null || code == null)
        {
            return View("Error");
        }

        var result = await _authService.EmailConfirmationAsync(userId, code);
        return View(result!.Succeeded ? "ConfirmEmail" : "Error");
    }
    #endregion

    #region Forgot Password
    //
    // GET: /Account/ForgotPassword
    [HttpGet, AllowAnonymous]
    public IActionResult ForgotPassword()
    {
        return View();
    }

    //
    // POST: /Account/ForgotPassword
    [HttpPost, AllowAnonymous, ValidateAntiForgeryToken]
    public async Task<IActionResult> ForgotPassword(ForgotPasswordDTO model)
    {
        if (ModelState.IsValid && !string.IsNullOrEmpty(model.Email))
        {
            var user = await _userInfo.FindUserByEmailAsync(model.Email);
            if (user == null || !await _userInfo.IsUserEmailConfirmedAsync(user))
            {
                // Don't reveal that the user does not exist or is not confirmed for security purposes
                return View("ForgotPasswordConfirmation");
            }
            else
            {
                var code = await _authService.PasswordResetTokenGeneratorAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

                var callbackUrl = Url.Action("ResetPassword", "Account", new { userId = user.Id, passwordResetToken = code }, protocol: Request.Scheme);
                var emailContent = await _fileHelpers.EmailTemplatesReaderAsync("PasswordReset.html");
                var emailSubject = emailContent.Replace("$$ResetPasswordLink$$", callbackUrl).Replace("$$CurrentYear$$", DateTime.Now.Year.ToString());
                //await _emailSender.SendEmailAsync(model.Email, "Reset Password",
                //emailSubject);
                return View("ForgotPasswordConfirmation");
            }
        }

        // If we got this far, something failed, redisplay form
        return View(model);
    }

    //
    // GET: /Account/ForgotPasswordConfirmation
    [HttpGet]
    [AllowAnonymous]
    public IActionResult ForgotPasswordConfirmation()
    {
        return View();
    }
    #endregion

    #region Reset Password
    //
    // GET: /Account/ResetPassword
    [HttpGet, AllowAnonymous]

    public IActionResult ResetPassword(string? passwordResetToken = null)
    {
        return passwordResetToken == null ? View("Error") : View();
        //return View();
    }

    //
    // POST: /Account/ResetPassword
    [HttpPost, AllowAnonymous, ValidateAntiForgeryToken]
    public async Task<IActionResult> ResetPassword(ResetPasswordDTO model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        if (!string.IsNullOrEmpty(model.Email))
        {
            var user = await _userInfo.FindUserByEmailAsync(model.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                return RedirectToAction(nameof(AccountController.ResetPasswordConfirmation), "Account");
            }

            if (user != null && !string.IsNullOrEmpty(model.PasswordResetToken))
            {
                model.PasswordResetToken = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(model.PasswordResetToken!));
                var isValid = await _authService.UserTokenVerificationAsync(user, model.PasswordResetToken);
                if (isValid)
                {
                    IdentityResult? result = await _authService.PasswordResetAsync(user, model.PasswordResetToken, model.Password!);
                    if (result != null && result.Succeeded)
                    {
                        return RedirectToAction(nameof(AccountController.ResetPasswordConfirmation), "Account");
                    }
                    AddErrors(result);
                }
            }
        }
        return View();
    }
    //
    // GET: /Account/ResetPasswordConfirmation
    [HttpGet, AllowAnonymous]
    public IActionResult ResetPasswordConfirmation()
    {
        return View();
    }
    #endregion

    #region Views Helpers

    private void AddErrors(IdentityResult? result)
    {
        if (result != null)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }
    }

    private IActionResult RedirectToLocal(string returnUrl)
    {
        if (Url.IsLocalUrl(returnUrl))
        {
            return Redirect(returnUrl);
        }
        else
        {
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController));
        }
    }
    #endregion
}
