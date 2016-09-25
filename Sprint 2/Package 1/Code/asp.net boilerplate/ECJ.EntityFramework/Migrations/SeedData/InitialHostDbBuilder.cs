using ECJ.EntityFramework;
using EntityFramework.DynamicFilters;

namespace ECJ.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ECJDbContext _context;

        public InitialHostDbBuilder(ECJDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
