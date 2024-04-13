using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
 using System.Xml;
using Microsoft.Extensions.Configuration;
using GoCompareShop.DAL;
using System.Reflection.Emit;
using GoCompareShop.Models;

namespace GoCompareShop.DAL
{
    public class ApplicationDBContext : IdentityDbContext<IdentityUser>
    {

        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            

        }

        private void SeedUsers(ModelBuilder modelBuilder)
        {
            //Seeding a  'Administrator' role to AspNetRoles table
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = "Administrator", NormalizedName = "ADMINISTRATOR".ToUpper() });
         
            //a hasher to hash the password before seeding the user to the db
            var hasher = new PasswordHasher<IdentityUser>();

            //Seeding the Admin user to AspNetUsers table
            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb9", // primary key
                    UserName = "admin@gc.com",
                    Email = "admin@gc.com",
                    NormalizedEmail = "ADMIN@GC.COM",
                    NormalizedUserName = "admin@gc.com",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PasswordHash = hasher.HashPassword(null, "Test12345!@")
                }
            );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
          new IdentityUserRole<string>
          {
              RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
              UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
          }
         );

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
