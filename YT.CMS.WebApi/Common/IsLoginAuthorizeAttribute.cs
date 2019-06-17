using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc; 

namespace System.Web.Mvc
{
    public class IsLoginAuthorizeAttribute : AuthorizeAttribute
    {
        /// <summary>
        /// 验证是否登录
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            return !string.IsNullOrEmpty(SessionHelper.UserID);
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            var content = new { };
            HttpContextBase contextBase = filterContext.HttpContext;

          
           
            //var response = filterContext.HttpContext.Response == filterContext.HttpContext.Response ?? new HttpResponseMessage();
            //response.StatusCode = HttpStatusCode.Forbidden;
            //var content = new Result
            //{
            //    success = false,
            //    errs = new[] { "服务端拒绝访问：你没有权限，或者掉线了" }
            //};
            //response.Content = new StringContent(Json.Encode(content), Encoding.UTF8, "application/json");
        }
    }
}