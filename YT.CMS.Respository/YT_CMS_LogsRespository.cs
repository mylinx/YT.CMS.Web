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
	public class   YT_CMS_LogsRespository: BaseRespository<YT_CMS_LogsEntity>, IYT_CMS_LogsRespository
    {
        public  YT_CMS_LogsRespository() : base("default")
        {

        } 
    }
}