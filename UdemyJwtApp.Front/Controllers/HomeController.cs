using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UdemyJwtApp.Front.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public string AdminPage()
        {
            return "Admin page";
        }

        [Authorize(Roles = "Member")]
        public string MemberPage()
        {
            return "Member Page";
        }
    }
}
