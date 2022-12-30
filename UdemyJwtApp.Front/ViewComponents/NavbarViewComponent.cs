using Microsoft.AspNetCore.Mvc;

namespace UdemyJwtApp.Front.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
