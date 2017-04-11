using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace ngquickstart
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            //loggerFactory.AddConsole();

            // to serve index.html as the default page
            //app.UseDefaultFiles();
            // to serve all the javascript, css and other static pages
            //app.UseStaticFiles("/wwwroot/src");
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(
          Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot", "src")),
                RequestPath = new PathString("")
            });

            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(
Path.Combine(Directory.GetCurrentDirectory(), @"node_modules")),
                RequestPath = new PathString("/node_modules")
            });
            // configure route for webapi
        }
        }
}
