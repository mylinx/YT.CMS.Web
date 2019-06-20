using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YT.CMS.Common
{
    public static class SessionHelper
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public static string UserID
        {
            get
            {
                if (HttpContext.Current.Session["ID"] != null)
                {
                    return HttpContext.Current.Session["ID"].ToString();
                }
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
                if (HttpContext.Current.Session["UserName"] != null)
                {
                    return HttpContext.Current.Session["UserName"].ToString();
                }
                return "";
            }
        }

        /// <summary>
        /// 用户名称
        /// </summary>
        public static string EnterpriseID
        {
            get
            {
                if (HttpContext.Current.Session["EnterpriseID"] != null)
                {
                    return HttpContext.Current.Session["EnterpriseID"].ToString();
                }
                return "";
            }
        }
    }
}