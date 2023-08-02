using System;
using Fitness_First.Areas.Identity.Data;
using Fitness_First.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Fitness_First.Areas.Identity.IdentityHostingStartup))]
namespace Fitness_First.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Fitness_FirstContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Fitness_FirstContextConnection")));

                services.AddDefaultIdentity<Fitness_FirstUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Fitness_FirstContext>();
            });
        }
    }
}