using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PopPopLib.PPAbstracts;
using PopPopLib.UseModels;
using PopPopLib.PPRepos;
using PopPopPotholesAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace PopPopPotholesAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV
            string connectionString = Configuration.GetConnectionString("PopPopPotholesDB");

            services.AddDbContext<PopPopPotholesDbContext>
                (options => options.UseSqlServer(connectionString));

            services.AddTransient<IRepositoryCity<City1>, CityRepository>();
            services.AddTransient<IRepositoryCityAdmin<CityAdmin1>, CityAdminRepository>();
            services.AddTransient<IRepositoryIssue<Issue1>, IssueRepository>();
            //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            // Add RequestLogging() - any request made will be logged.
            app.UseSerilogRequestLogging();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            //app.UseEndpoints(endpoints =>
            //{
            //endpoints.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Home}/{action=index}/{id?}");
            //});
        }
    }
}
