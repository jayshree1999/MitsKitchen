using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MitsKitchen.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MitsKitchen.Data
{
    public class ApplicationDbContext : IdentityDbContext<MyIdentityUser,MyIdentityRole,Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<MitsKitchen.Models.Category> Category { get; set; }

        public DbSet<MitsKitchen.Models.Product> Product { get; set; }

       
       
    }
}
