using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CornerStoneApp.Areas.Admin.Controllers
{
    public class UsersController: Controller
    {
        [Authorize(Roles ="admin")]
        public ActionResult Index()
        {
            return Content("Users!");
        }
    }
}