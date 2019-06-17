using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YT.CMS.IRespository;
using YT.CMS.Respository;
using YT.CMS.Entity;

namespace System.Web.Mvc
{
    /// <summary>
    /// 登陆授权验证
    /// </summary>
    public class IsPerssionAuthorizeAttribute: AuthorizeAttribute
    { 
        /// <summary>
        /// 权限验证在此处
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            //YT_CMS_UsersEntity entitys = new YT_CMS_UsersEntity();
            IYT_CMS_UsersRespository usersResponsitory = new YT_CMS_UsersRespository();



            //判断当前登陆用户是否有权限访问该controller
            return false;
        }



        /// <summary>
        /// 没有通过授权验证之后,需要在此处理,如跳转
        /// </summary>
        /// <param name="filterContext"></param>
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            //base.HandleUnauthorizedRequest(filterContext);
            if (SessionHelper.UserID == "")
            {
                filterContext.HttpContext.Response.Redirect("/Account/Login");
            }
        }


        protected override HttpValidationStatus OnCacheAuthorization(HttpContextBase httpContext)
        {
            return base.OnCacheAuthorization(httpContext);
        }
    }
}