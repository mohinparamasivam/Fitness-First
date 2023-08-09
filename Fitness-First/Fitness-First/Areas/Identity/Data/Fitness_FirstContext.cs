using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness_First.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Fitness_First.Data
{
    public class Fitness_FirstContext : IdentityDbContext<Fitness_FirstUser>
    {
        public Fitness_FirstContext(DbContextOptions<Fitness_FirstContext> options)
            : base(options)
        {
        }

        public DbSet<Fitness_First.Models.GymPackages> GymPackages { get; set; }

        public DbSet<Fitness_First.Models.Products> Products { get; set; }

        public DbSet<Fitness_First.Models.GymEquipments> GymEquipments { get; set; }

        public DbSet<Fitness_First.Models.PackageEnrollment> PackageEnrollments { get; set; }
        public DbSet<Fitness_First.Models.ProductPurchase> ProductPurchases { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
