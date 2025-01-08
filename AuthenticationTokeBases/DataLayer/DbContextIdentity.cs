using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationTokeBases.DataLayer
{
    public class DbContextIdentity : IdentityDbContext
    {
        public DbContextIdentity(DbContextOptions<DbContextIdentity> options) : base(options)
        {
            
        }
    }
}
