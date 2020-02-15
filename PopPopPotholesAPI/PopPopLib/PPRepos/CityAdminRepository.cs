using System;
using System.Collections.Generic;
using System.Text;
using PopPopLib.PPAbstracts;
using PopPopLib.UseModels;
using System.Linq;
using PopPopPotholesAPI.Domain.Models;
using Microsoft.Extensions.Logging;

namespace PopPopLib.PPRepos
{
    public class CityAdminRepository : IRepositoryCityAdmin<CityAdmin1>
    {
        PopPopPotholesDbContext _PPPDB;
        private readonly ILogger<CityAdminRepository> _logger;

        public CityAdminRepository(PopPopPotholesDbContext PPPDB, ILogger<CityAdminRepository> logger)
        {
            _PPPDB = PPPDB;
            _logger = logger;
        }

        public void CreateCityAdmin(CityAdmin1 CityAdmin)
        {
            _PPPDB.CityAdmin.Add(Mappings.MapCityAdmin.Map(CityAdmin));// this will generate insertMapper.Map(customer)
            _PPPDB.SaveChanges();// this will execute the above generate insert query

            // log in behavior for adding in new City Admin
            _logger.LogInformation(1001, "Added new City Admin {0} to database\n", CityAdmin.Email);
        }

        public void DeleteCityAdmin(int Id)
        {
            var CA = _PPPDB.CityAdmin.FirstOrDefault(ca => ca.Id == Id);
            if (CA.Id == Id)
            {
                _PPPDB.Remove(CA);
                _PPPDB.SaveChanges();

                // log in behavior for adding in new City Admin
                _logger.LogInformation(1002, "Deleted City Admin ID:{0} from database\n", Id);
            }
            else
            {
                Console.WriteLine($"City Admin with id {Id} doesn't exist");

                // log in behavior for adding in new City Admin
                _logger.LogWarning(1101, "Unable to delete City Admin from database: {0} Doesn't Exist\n", Id);
                return;
            }
        }

        public IEnumerable<CityAdmin1> ReadInCityAdmin()
        {
            var cityAdmin = from CA in _PPPDB.CityAdmin
                        select Mappings.MapCityAdmin.Map(CA);

            // log in behavior for adding in new City Admin
            _logger.LogInformation(1003, "Get Request for all CityAdmin from database\n");

            return cityAdmin;
        }

        public void UpdateCityAdmin(CityAdmin1 CityAdmin)
        {
            // log in behavior for adding in new City Admin
            _logger.LogInformation(1004, "Updated City Admin {0} to database\n", CityAdmin.Email);

            throw new NotImplementedException();
        }
    }
}
