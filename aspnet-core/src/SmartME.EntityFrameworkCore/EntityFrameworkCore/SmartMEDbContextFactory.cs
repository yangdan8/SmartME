using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SmartME.Configuration;
using SmartME.Web;

namespace SmartME.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SmartMEDbContextFactory : IDesignTimeDbContextFactory<SmartMEDbContext>
    {
        public SmartMEDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SmartMEDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SmartMEDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SmartMEConsts.ConnectionStringName));

            return new SmartMEDbContext(builder.Options);
        }
    }
}
