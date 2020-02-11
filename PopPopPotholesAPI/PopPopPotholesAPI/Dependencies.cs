using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using PopPopPotholesAPI.Domain.Models;

namespace PopPopPotholesAPI
{
    public class Dependencies
    {
        static PopPopPotholesDbContext dbContext;

        static void Setup()
        {
            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = configBuilder.Build();

            var optionsBuilder = new DbContextOptionsBuilder<PopPopPotholesDbContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("PopPopPotholesDb"));
            var options = optionsBuilder.Options;
            dbContext = new PopPopPotholesDbContext(options);
        }

        public static PopPopPotholesDbContext GetDbContext()
        {
            if (dbContext == null)
                Setup();

            return dbContext;
        }
    }
}
