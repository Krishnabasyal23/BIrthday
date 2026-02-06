namespace BIrthday.Models
{
    public class StoryChapter
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public Boolean isFinal { get; set; }
        public string Mood { get; set; }
    }
}
// learn to insert emojis {get, set}="";