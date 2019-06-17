using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.CMS.Core;
using YT.CMS.Entity;
using YT.CMS.IRespository;
namespace YT.CMS.Respository
{ 
	public class   YT_CMS_UsersRespository: BaseRespository<YT_CMS_UsersEntity>, IYT_CMS_UsersRespository
    {
        public  YT_CMS_UsersRespository() : base("default")
        {

        }

    }
}