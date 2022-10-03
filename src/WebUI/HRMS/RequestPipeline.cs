namespace WebUI;
public static class RequestPipeline
{
    public static IApplicationBuilder AddRequestPipeline(this IApplicationBuilder middlewares)
    {

        middlewares.UseHttpsRedirection();
        middlewares.UseStaticFiles();
        // middlewares.UseCookiePolicy();
        middlewares.UseRouting();
        //middlewares.UseRequestLocalization();
        //middlewares.UseCors();
        middlewares.UseAuthentication();
        middlewares.UseAuthorization();
        middlewares.UseSession();
        //middlewares.UseResponseCompression();
        //middlewares.UseResponseCaching();

        return middlewares;
    }
}
