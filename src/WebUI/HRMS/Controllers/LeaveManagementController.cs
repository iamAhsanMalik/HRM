using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers;
public class LeaveManagementController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
