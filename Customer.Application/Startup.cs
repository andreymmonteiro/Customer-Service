using Customer.CrossCutting;
using Customer.Data.Context;
using Customer.Domain.Models.DatabaseModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.Application
{
    public class Startup
    {
        private const string ConnectionString = "ConnectionStrings:Default";
        private IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGrpc();
            ConfigureDatabase.Connection = Configuration.GetSection(ConnectionString).Value;
            InitializeDatabase(services);
        }

        private static void InitializeDatabase(IServiceCollection services)
        {
            ConfigureDatabase.AddDatabase();
            ConfigureDatabase.InitializeDb(DatabaseTypes.mySql, services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<GreeterService>();

                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
                });
            });

            using var service = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();

            using var context = service.ServiceProvider.GetService<MyContext>();
            context.Database.Migrate();
            
            
        }
    }
}
