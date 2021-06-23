using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2021_06_23_FileUpload
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            //using (FileUploadContext context = new FileUploadContext())
            //{

            //    context.Database.EnsureDeleted();
            //    context.Database.EnsureCreated();
            //    //context.Database.EnsureDeleted();

            //    //DatenAnlegen(context);

            //    //Load(context);

            //    //EagerLoading(context);

            //    //LazyLoading(context);

            //    //ExplicitlyLoading(context);

            //}
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
