using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YT.CMS.IRespository;
using YT.CMS.Respository;
using YT.CMS.Common;
namespace YT.CMS.Webs.Controllers
{
    public class HomeController : BaseController
    {

        private IYT_CMS_UsersRespository userRespository;


        public ActionResult Login()
        {
            Session["ID"] = "1";
            // return RedirectToAction("Index", "Home", new {  area= "AdminArea" });
            return View();
        }


        public FileResult VerifityCode()
        {
            return File(VerifyCode.GetVerifyCode(), "image/jpg");
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}