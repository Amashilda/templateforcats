using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateForCats.Models
{
    public class ArticleModel
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }

       public ICollection<CommentItemModel> Comments { get; set; }
    }
}