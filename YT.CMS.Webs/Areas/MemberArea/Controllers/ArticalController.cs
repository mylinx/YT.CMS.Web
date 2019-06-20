using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YT.CMS.Webs.Areas.MemberArea.Controllers
{
    public class ArticalController : BaseController
    {
        // GET: MemberArea/Artical
        public ActionResult Index()
        {
            return View();
        }
    }
}