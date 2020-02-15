using System;
using System.Collections.Generic;
using System.Text;
using PopPopLib.UseModels;
using PopPopLib.PPAbstracts;
using PopPopPotholesAPI.Domain.Models;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace PopPopLib.PPRepos
{
    public class CityRepository : IRepositoryCity<City1>
    {
        PopPopPotholesDbContext _PPPDB;
        private readonly ILogger<CityRepository> _logger;

        public CityRepository(PopPopPotholesDbContext PPPDB, ILogger<CityRepository> logger)
        {
            _logger = logger;
            _PPPDB = PPPDB;
        }


        public void CreateCity(City1 City)
        {
            _PPPDB.Add(Mappings.MapCity.Map(City));// this will generate insertMapper.Map(customer)
            _PPPDB.SaveChanges();// this will execute the above generate insert query

            // log in behavior for adding in new City Admin
            _logger.LogInformation(2001, "Added new City {0} to database", City.cityName);
        }

        public void DeleteCity(int Id)
        {
            var City = _PPPDB.City.FirstOrDefault(Cx => Cx.Id == Id);
            if (City.Id == Id)
            {
                _PPPDB.Remove(City);
                _PPPDB.SaveChanges();

                // log in behavior for adding in new City Admin
                _logger.LogInformation(2002, "Added new City: {0} to database", Id);
            }
            else
            {
                Console.WriteLine($"City with id {Id} doesn't exist");

                // log in behavior for adding in new City Admin
                _logger.LogWarning(2101, "Added new City Admin {0} to database", Id);
                return;
            }
        }

        public IEnumerable<City1> ReadInCity()
        {
            var getCity = from IX in _PPPDB.City
                           select Mappings.MapCity.Map(IX);

            // log in behavior for adding in new City Admin
            _logger.LogInformation(2003, "Return all Cities in database");

            return getCity;
        }

        public void UpdateCity(City1 City)
        {
            // log in behavior for adding in new City Admin
            _logger.LogInformation(2004, "Updated City {0} to database", City.cityName);

            throw new NotImplementedException();
        }
    }
}
