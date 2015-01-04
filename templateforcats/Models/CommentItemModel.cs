using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateForCats.Models
{
    public class CommentItemModel
    {
        public string Username { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
    }
}