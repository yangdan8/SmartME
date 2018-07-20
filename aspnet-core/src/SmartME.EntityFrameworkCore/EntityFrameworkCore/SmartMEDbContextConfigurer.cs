using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SmartME.EntityFrameworkCore
{
    public static class SmartMEDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SmartMEDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SmartMEDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
