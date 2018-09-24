using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using Funq;
using ServiceStack;
using System;
using System.Threading;
using System.Threading.Tasks;
using vsCode.Requests;

namespace vsCode
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => this._config = configuration;

        private IConfiguration _config { get; }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseServiceStack(new AppHost
            {
                AppSettings = new NetCoreAppSettings(this._config)
            });

            app.Run (context =>
            {
                context.Response.Redirect ("/index.html");
                return Task.FromResult (0);
            });
        }
    }

        public class AppHost : AppHostBase
    {
        // Initializes your AppHost Instance, with the Service Name and assembly containing the Services
        public AppHost() : base("Test API", typeof(vsCode.Requests.Request).Assembly) {}

        // Configure your AppHost with the necessary configuration and dependencies your App needs
        
        public override void Configure(Container container)
        {
        }
    }
}