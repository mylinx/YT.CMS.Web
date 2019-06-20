using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YT.CMS.Common;
using YT.CMS.Entity;
using YT.CMS.IRespository;
using YT.CMS.Respository;


namespace YT.CMS.Webs.Controllers
{
    public class BaseController : Controller
    {
        readonly IYT_CMS_LogsRespository logresponsitory;
        public BaseController()
        {
            logresponsitory = new YT_CMS_LogsRespository(); 
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            YT_CMS_LogsEntity entity = new YT_CMS_LogsEntity();
            try
            {
                entity.ID = Guid.NewGuid().ToString();
                entity.LogType = LogsTypeEmuns.Erro.ToString();
                entity.LogContent = "正常访问";
                entity.ActionName = filterContext.RouteData.Values["action"].ToString();
                entity.ContollerName = filterContext.RouteData.Values["controller"].ToString();
                entity.CreateTime = DateTime.Now;
                entity.UpdateTime = DateTime.Now;
                entity.Remark = Guid.NewGuid().ToString();
                logresponsitory.Add(entity);
                logresponsitory.SaveChange();
            }
            finally
            {

            }
            base.OnActionExecuted(filterContext);
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
          
            base.OnActionExecuting(filterContext);
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            YT_CMS_LogsEntity entity = new YT_CMS_LogsEntity();
            try
            {
                entity.ID = Guid.NewGuid().ToString();
                entity.LogType = LogsTypeEmuns.Erro.ToString();
                entity.LogContent = filterContext.Exception.Message.ToString();
                entity.ActionName = filterContext.RouteData.Values["action"].ToString();
                entity.ContollerName = filterContext.RouteData.Values["controller"].ToString();
                entity.CreateTime = DateTime.Now;
                entity.UpdateTime = DateTime.Now;
                entity.Remark = Guid.NewGuid().ToString();
                logresponsitory.Add(entity);
                logresponsitory.SaveChange();
            }
            finally
            {

            }
            filterContext.HttpContext.Response.Redirect("~/Home/Erro");
        } 
    }
}