using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SmartME.Authorization.Roles;
using SmartME.Authorization.Users;
using SmartME.MultiTenancy;

namespace SmartME.EntityFrameworkCore
{
    public class SmartMEDbContext : AbpZeroDbContext<Tenant, Role, User, SmartMEDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SmartMEDbContext(DbContextOptions<SmartMEDbContext> options)
            : base(options)
        {
        }
    }
}
