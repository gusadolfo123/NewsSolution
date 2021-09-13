using System;

namespace Domain.Entities
{
    public class Article
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public string URLToImage { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Content { get; set; }
    }
}
