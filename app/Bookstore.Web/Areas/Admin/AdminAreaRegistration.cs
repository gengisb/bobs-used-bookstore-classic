using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Bookstore.Web.Areas
{
    public class AdminAreaRegistration
    {
        public static string AreaName => "Admin";

        public static void RegisterArea(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapAreaControllerRoute(
                name: "Admin_default",
                areaName: AreaName,
                pattern: "Admin/{controller=Home}/{action=Index}/{id?}",
                defaults: new { area = AreaName }
            );
        }
    }
}