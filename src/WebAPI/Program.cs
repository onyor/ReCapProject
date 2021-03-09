using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace WebAPI
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            // SERILOG configuration
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var host = CreateHostBuilder(args).Build();


            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<RentACarContext>();

                    if (context.Database.GetPendingMigrations().Any())
                    {
                        // Log.Information("Starting database migration...");
                        await context.Database.MigrateAsync();
                    }

                    //var userManager = services.GetRequiredService<UserManager<User>>();
                    //var roleManager = services.GetRequiredService<RoleManager<Role>>();
                    //await SeedData.SeedUsersAsync(userManager, roleManager);
                }
                catch (Exception ex)
                {

                }
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
