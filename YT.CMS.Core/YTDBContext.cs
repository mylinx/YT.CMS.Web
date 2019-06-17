using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace YT.CMS.Core
{
    public class YTDBContext:DbContext
    {

        public YTDBContext(string name):base(name)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            string assembleFileName = Assembly.GetExecutingAssembly().CodeBase.Replace("YT.CMS.Core.DLL", "YT.CMS.Mapping.DLL").Replace("file:///", "");
            Assembly asm = Assembly.LoadFile(assembleFileName);
            var typesToRegister = asm.GetTypes()
                   .Where(type => !string.IsNullOrWhiteSpace(type.Namespace))
            .Where(type => type.GetTypeInfo().IsClass)
            .Where(type => type.GetTypeInfo().BaseType != null)
           // .Where(q => q.GetInterface(typeof(EntityTypeConfiguration<>).FullName) != null)
            .ToList();
            foreach (var entityType in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(entityType);
                modelBuilder.Configurations.Add(configurationInstance);
            }
        }
    }
} 
