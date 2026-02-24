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
                    Title="yooo 0/",
                    Mood="intro",
                    Body= "This isn't just a webiste.\nIt's a small pause.\n A quiet moment before i reveal something dumb "


                },
                new StoryChapter
                {
                    Id=1,
                    Title="A small journey begins",
                    Mood="intro",
                    Body= " This was made just for you. \n"+ "(Also for my learning purposes),\n" +
                    "Don't hit me please, I actually tired with this",
                },
                new StoryChapter
                {
                    Id=2,
                    Title="A quiet chapter",
                    Mood="reflective",
                    Body="For someone who moves through the world with kindness, curiosity and aspires to a pishachini"
                },
                new StoryChapter
                {
                    Id=3,
                    Title = "A quiet moment",
                    Body = "Some stories don't start loudly.\nThey start with curiosity, kindness, courage,\nand a boring day at the student life wait table.",
                    Mood = "cozy",
                    isFinal = false
                },

                new StoryChapter
                {
                    Id=4,
                    Title="Some people carry stories gently",
                    Mood="reflective",
                    Body="For someone who moves through the world with kindness, curiosity, \n and aspires to a pishachini"
                },
                 new StoryChapter
                 {
                     Id=5,
                     Title= "Another Chapter",
                     Body="Today is not about big fireworks (broke) \n It's about celebrating the way you exist \n and flexign my coding muscles. ",
                     Mood="soft-final"
                 },

                 new StoryChapter
                 {
                     Id=6,
                     Title="You once gave me a book",
                     Mood="warm",
                     Body="A story about finding light where none should exist "
                 },
                new StoryChapter
                {
                    Id=7,
                    Mood= "reflective",
                    Title="And today...",
                    Body=" This chapter is yours.",
                    isFinal= true
                },
                 new StoryChapter
                 {
                     Id=4,
                     Title="Some people carry stories gently",
                     Mood="reflective",
                     Body=" Probably cause they got amazing biceps\n"+
                     "They listen, they remember(🐟) and then threaten to beat you"

                 },
                  new StoryChapter
                 {
                     Id=6,
                     Title="Chef arc unlocked",
                     Mood="cozy",
                     Body="you cook great 👍"

                 },
                  new StoryChapter
                  {
                      Id=7,
                      Title="If life was a game",
                      Mood="Playful",
                      Body="Youd be the S-tier who says they're bad \n but carries the whole squad."
                      +"\n but also threatens to log off and bonk everyone"
                  },
                  new StoryChapter
                  {
                      Id=8,
                      Title="A wile day appears",
                      Mood= "playful",
                      Body="If you were a pokemon \n"+
                      "You'd be a rare spawn with maxed out sass and kindness"+
                      "10/10 would catch again. \n"

                  },

                  new StoryChapter
                  {
                      Id=9,
                      Title= "And Today....",
                      Mood="cozy",
                      Body="Today isn't about big fireworks (broke). \n"+
                      "It's about celebrating the way you exist, \n"+
                      " and flexing my coding muscles just a little",
                      //isFinal=true
                  },
                 new StoryChapter
                 {
                     Id=20,
                     Title="Some heros never log out",
                     Mood="tribute",
                     Body="Not all kings wear crowns, but this one did \n"+
                     "Some carry kindness, humor, and quiet strength. \n\n"+
                     " and the coolest part about us, we both believe in the BLOOD FOR THE BLOOD GOD"+
                     "Technoblade never dies.."

                 },
                 new StoryChapter
                {
                    Id=99,
                    Title="Happy Birthday",
                    Mood="celebration",
                    Body=" Happy Birthday, NERDDDDDD\n"+
                    "You are a Mythical Meance\n",
                   
                    isFinal=true
                },

            };

            return View(chapters);
        }
    }
}
