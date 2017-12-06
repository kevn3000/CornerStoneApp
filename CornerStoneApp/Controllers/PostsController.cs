using CornerStoneApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CornerStoneApp.Controllers
{
    public class PostsController : Controller
    {
      public ActionResult Index()
        {
            //Guardian kevin = new Guardian("kevin", "serrano", true);
            //return Content(kevin.firstName +" "+kevin.lastName+" is a "+kevin.membership.isActive+" member!");
            return View();
        }
        public ActionResult Test()

        {
            return Content("Test() is opened");
        }
    }
}
