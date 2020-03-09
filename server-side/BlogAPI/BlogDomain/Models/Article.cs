using System;

namespace BlogDomain.Models
{
    public class Article
    {
        public int? Id { get; set; }

        public string Title { get; set; }

        public DateTime PubDate { get; set; }

        public string Text { get; set; }
    }
}