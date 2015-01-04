using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TemplateForCats.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var model = new ArticleModel();
            model.Body = "<p> BODY TEXT BODY TEXT BODY TEXT BODY TEXT BODY TEXT BODY TEXT BODY TEXT</P>";
            return View();
        }

    }
}
