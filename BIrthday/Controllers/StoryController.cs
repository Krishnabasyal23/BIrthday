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
                    Mood="calm",
                    Body= "This isn't just a webiste.\nIt's a small pause.\n A quiet moment before i reveal something dumb "
                },
                new StoryChapter
                {
                    Id=1,
                    Title="A quiet chapter",
                    Mood="reflective",
                    Body="For someone who moves through the world with kindness, curiosity and aspires to a pishachini"
                },
                new StoryChapter
                {
                    Id=2,
                    Title="Some people carry stories gently",
                    Mood="reflective",
                    Body="They dont announce themselves loudly, but you /n you yap a lot"
                },
                 new StoryChapter
                 {
                     Id=3,
                     Title="You once gave me a book",
                     Mood="warm",
                     Body="A story about finding light where none should exist "
                 },
                new StoryChapter
                {
                    Id=3,
                    Title="And today...",
                    Body=" This chapter is yours."
                }

            };

            return View(chapters);
        }
    }
}
