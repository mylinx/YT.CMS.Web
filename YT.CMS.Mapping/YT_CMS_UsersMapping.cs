using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.CMS.Entity;

namespace YT.CMS.Mapping
{ 
	public class YT_CMS_UsersMapping: EntityTypeConfiguration<YT_CMS_UsersEntity>
	{
		public YT_CMS_UsersMapping()
	      {
	            this.ToTable("YT_CMS_Users");
	      }
	}
}