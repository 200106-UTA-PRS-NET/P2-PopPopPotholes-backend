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
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.IO;
using System.Web.Cors;


namespace PopPopPotholesAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // 
        readonly string MyAllowSpecificationOrigins = "_myAllowSpecificOrigins";

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //- CORS-------------------------------------------------------------------
            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificationOrigins,
                builder =>
                {
                    builder.AllowAnyOrigin().
                    AllowAnyHeader().
                    AllowAnyMethod();
                });
            });
            //---------------------------------------------------------------------------

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo {
                    Version = "v1",
                    Title = "Contact API", 
                    Description = "API describes the collection of general r" +
                        "oadside issues the local population may want to voice",
                    TermsOfService = new Uri("https://poppoppotholes.azurewebsites.net/api/issue"),
                    //TermsOfService = new Uri("localhost:4200/api/issue"),
                    Contact = new OpenApiContact
                    {
                        Name = "Kyle\nZach\nJeremy",
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under PPP",
                    }
                });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                options.IncludeXmlComments(xmlPath);
            });
            string connectionString = Configuration.GetConnectionString("PopPopPotholesDB");

            services.AddDbContext<PopPopPotholesDbContext>
                (options => options.UseSqlServer(connectionString));

            services.AddTransient<IRepositoryCity<City1>, CityRepository>();
            services.AddTransient<IRepositoryCityAdmin<CityAdmin1>, CityAdminRepository>();
            services.AddTransient<IRepositoryIssue<Issue1>, IssueRepository>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });



            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            // Add RequestLogging() - any request made will be logged.
            app.UseSerilogRequestLogging();

            app.UseRouting();

            app.UseAuthorization();

            // CORS ---------------------------------
            app.UseCors(MyAllowSpecificationOrigins);
            //---------------------------------------

            app.UseHttpsRedirection();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
