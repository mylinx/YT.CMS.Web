using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace System.Web
{
    public static class SessionHelper
    { 
        /// <summary>
        /// 用户ID
        /// </summary>
        public static  string  UserID
        {
            get
            {
                if (HttpContext.Current.Session["userid"] != null)
                    return HttpContext.Current.Session["userid"].ToString();
                else
                    return "";
            }
        }

        /// <summary>
        /// 用户名称
        /// </summary>
        public static string UserName
        {
            get
            {
                if (HttpContext.Current.Session["username"] != null)
                    return HttpContext.Current.Session["username"].ToString();
                else
                    return "";
            }
        }


        /// <summary>
        /// 角色ID
        /// </summary>
        public static string RoleID
        {
            get
            {
                if (HttpContext.Current.Session["roleid"] != null)
                    return HttpContext.Current.Session["roleid"].ToString();
                else
                    return "";
            }
        }


        /// <summary>
        /// 角色名称
        /// </summary>
        public static string RoleName
        {
            get
            {
                if (HttpContext.Current.Session["rolename"] != null)
                    return HttpContext.Current.Session["rolename"].ToString();
                else
                    return "";
            }
        }
    }
}