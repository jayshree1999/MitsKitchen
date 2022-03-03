using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MitsKitchen.Data;
using MitsKitchen.Models;

[assembly: HostingStartup(typeof(MitsKitchen.Areas.Identity.IdentityHostingStartup))]
namespace MitsKitchen.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
          //  builder.ConfigureServices((context, services) => {
            //    services.AddDbContext<ApplicationDbContext>(options =>
             //       options.UseSqlServer(
                  //      context.Configuration.GetConnectionString("DefaultConnection")));

               // services.AddDefaultIdentity<MyIdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    //.AddEntityFrameworkStores<ApplicationDbContext>();
           // });
        }
    }
}