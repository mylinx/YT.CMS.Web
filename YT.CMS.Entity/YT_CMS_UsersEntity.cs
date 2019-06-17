using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace YT.CMS.Entity
{
    //YT_CMS_Users
    public class YT_CMS_UsersEntity
    {

        /// <summary>
        /// ID
        /// </summary>
        public string ID
        {
            get;
            set;
        }
        /// <summary>
        /// UserName
        /// </summary>
        public string UserName
        {
            get;
            set;
        }
        /// <summary>
        /// Account
        /// </summary>
        public string Account
        {
            get;
            set;
        }
        /// <summary>
        /// Password
        /// </summary>
        public string Password
        {
            get;
            set;
        }
        /// <summary>
        /// IsLock
        /// </summary>
        public bool IsLock
        {
            get;
            set;
        }
        /// <summary>
        /// IsDelete
        /// </summary>
        public bool IsDelete
        {
            get;
            set;
        }
        /// <summary>
        /// CreateTime
        /// </summary>
        public DateTime? CreateTime
        {
            get;
            set;
        }
        /// <summary>
        /// UpdateTime
        /// </summary>
        public DateTime? UpdateTime
        {
            get;
            set;
        }
        /// <summary>
        /// Remark
        /// </summary>
        public DateTime? Remark
        {
            get;
            set;
        }

    }
}