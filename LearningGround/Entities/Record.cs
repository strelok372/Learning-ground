namespace LearningGround.Entities
{
    public class Record
    {
        public string Title { get; set; }

        public string Tag { get; set; }

        public string Body { get; set; }

        public Record(string title, string tag, string body)
        {
            Title = title;
            Tag = tag;
            Body = body;
        }
    }
}
