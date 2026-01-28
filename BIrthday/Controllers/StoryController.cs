using BIrthday.Models;
using Microsoft.AspNetCore.Mvc;

namespace BIrthday.Controllers
{
    public class StoryController : Controller
    {
        public IActionResult Index()
        {
            var chapters = new List<StoryChapter>
            {
                new StoryChapter
                {
                    Id=0,
                    Title="yooo 🫡",
                    Body= "This isn't just a webiste.It's a small pause. "
                },
                new StoryChapter
                {
                    Id=1,
                    Title="A quiet chapter",
                    Body="For someone who moves through the world with kindness, curiosity and aspires to a pishachini"
                },
                new StoryChapter
                {
                    Id=2,
                    Title="And today...",
                    Body=" This chapter is yours."
                }

            };

            return View(chapters);
        }
    }
}
