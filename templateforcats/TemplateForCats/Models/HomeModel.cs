using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateForCats.Models
{
    public class HomeModel
    {
        public RecentDataModel RecentPosts { get; set; }
        public RecentDataModel RecentComment { get; set; }

    }
}