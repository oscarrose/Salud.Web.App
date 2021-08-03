using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Salud.Web.App.Services;
using Microsoft.Extensions.Hosting;

namespace Salud.Web.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var host = BuildWebHost(args);
            //using (var scope = host.Services.CreateScope())
            //{
            //    var services = scope.ServiceProvider;
            //    try
            //    {
            //        DbInitialize.CreateRoles(services).Wait();

            //    }
            //    catch (Exception ex)
            //    {

            //        var logger = services.GetRequiredService<ILogger<Program>>();
            //        logger.LogError(ex, "Error ocurred while seeding the database");
            //    }

            //}
            //host.Run();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
           Host.CreateDefaultBuilder(args)
               .ConfigureWebHostDefaults(webBuilder =>
               {
                   webBuilder.UseStartup<Startup>();
               });

    }
}
