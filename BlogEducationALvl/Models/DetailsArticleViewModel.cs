using System;

namespace BlogEducationALvl.Models
{
    public class DetailsArticleViewModel
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }
        public string AuthorNick { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }
    }
}