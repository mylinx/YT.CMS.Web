using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YT.CMS.Webs.Areas.AdminArea.Controllers
{
    public class HomeController : BaseController
    {
        // GET: AdminArea/Home
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ResultIndex()
        {
            return View();
        }
    }
}