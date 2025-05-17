using System.Collections.Generic;
using System.Reflection.Emit;
using System.Collections.Generic;
using InsurancePolicies.Models;
using Microsoft.EntityFrameworkCore;

namespace InsurancePolicies.Data
{
    public class AppDbContext : DbContext
    {
       
    
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }

            public DbSet<InsurancePolicy> Policy { get; set; }
            

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<InsurancePolicy>().HasKey(x => x.Id);
            modelBuilder.Entity<InsurancePolicy>().ToTable("Policy");

            modelBuilder.Entity<InsurancePolicy>().HasData(
            new InsurancePolicy
            {
                Id = 1,
                PolicyHolderName = "John Mwangi",
                PolicyNumber = "POL123456",
                PolicyType = "Health",
                PremiumAmount = 15000.00m,
                IsActive = true
            },
            new InsurancePolicy
            {
                Id = 2,
                PolicyHolderName = "Alice Wanjiku",
                PolicyNumber = "POL234567",
                PolicyType = "Life",
                PremiumAmount = 25000.00m,
                IsActive = true
            },
            new InsurancePolicy
            {
                Id = 3,
                PolicyHolderName = "Brian Otieno",
                PolicyNumber = "POL345678",
                PolicyType = "Vehicle",
                PremiumAmount = 8000.50m,
                IsActive = false
            },
            new InsurancePolicy
            {
                Id = 4,
                PolicyHolderName = "Faith Njeri",
                PolicyNumber = "POL456789",
                PolicyType = "Home",
                PremiumAmount = 12000.75m,
                IsActive = true
            },
            new InsurancePolicy
            {
                Id = 5,
                PolicyHolderName = "Elvis Kiptoo",
                PolicyNumber = "POL567890",
                PolicyType = "Travel",
                PremiumAmount = 6000.00m,
                IsActive = false
            }
            );





            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<CartItem>().HasKey(s => s.CartId);

            //modelBuilder.Entity<Book>()
            //    .HasOne(s => s.CartItem)
            //    .WithMany(x => x.Books)
            //    .HasForeignKey(s => s.CartId);

            // seeder

            //modelBuilder.Entity<CartItem>().HasData(
            //new CartItem { CartId = 1, CategoryName = "swahili Novels", Description = "swahili Novels only" },
            //new CartItem { CartId = 2, CategoryName = "Religion books", Description = "Religion books and  buddism" },
            //new CartItem { CartId = 3, CategoryName = "Business related", Description = "Business related books and artricles" },
            //new CartItem { CartId = 4, CategoryName = "Technology ", Description = "Technology and   Cloud " },
            //new CartItem { CartId = 5, CategoryName = "Space and Austronomy", Description = "Space and Austronomy" },
            //new CartItem { CartId = 6, CategoryName = "English  and  Foreign  Languages ", Description = "English  and  Foreign  Languages" }
            //);










        }
    }
    }


