using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SellJam.Data;
using System.Reflection.Emit;

namespace SellJam.Data
{
    public class ApplicationDbContext :IdentityDbContext <AccountIdentity,ApplicationRole,string>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<UserInfor> userInfors { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
           

            base.OnModelCreating(builder);
        }
    }
}
