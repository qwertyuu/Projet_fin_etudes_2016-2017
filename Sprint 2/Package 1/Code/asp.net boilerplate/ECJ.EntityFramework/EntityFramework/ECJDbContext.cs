using System.Data.Common;
using Abp.Zero.EntityFramework;
using ECJ.Authorization.Roles;
using ECJ.MultiTenancy;
using ECJ.Users;

namespace ECJ.EntityFramework
{
    public class ECJDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ECJDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ECJDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ECJDbContext since ABP automatically handles it.
         */
        public ECJDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ECJDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
