using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using ECJ.EntityFramework;

namespace ECJ.Migrator
{
    [DependsOn(typeof(ECJDataModule))]
    public class ECJMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ECJDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}