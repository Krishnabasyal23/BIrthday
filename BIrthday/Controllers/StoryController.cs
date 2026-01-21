using Microsoft.AspNetCore.Mvc;

namespace BIrthday.Controllers
{
    public class StoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
