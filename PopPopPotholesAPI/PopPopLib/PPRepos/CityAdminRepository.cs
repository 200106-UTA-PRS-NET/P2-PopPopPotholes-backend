using System;
using System.Collections.Generic;
using System.Text;
using PopPopLib.PPAbstracts;
using PopPopLib.UseModels;
using System.Linq;
using PopPopPotholesAPI.Domain.Models;

namespace PopPopLib.PPRepos
{
    public class CityAdminRepository : IRepositoryCityAdmin<CityAdmin1>
    {
        PopPopPotholesDbContext _PPPDB;
        public CityAdminRepository(PopPopPotholesDbContext PPPDB)
        {
            _PPPDB = PPPDB;
        }




        public void CreateCityAdmin(CityAdmin1 CityAdmin)
        {
            _PPPDB.CityAdmin.Add(Mappings.MapCityAdmin.Map(CityAdmin));// this will generate insertMapper.Map(customer)
            _PPPDB.SaveChanges();// this will execute the above generate insert query
        }

        public void DeleteCityAdmin(int Id)
        {
            var CA = _PPPDB.CityAdmin.FirstOrDefault(ca => ca.Id == Id);
            if (CA.Id == Id)
            {
                _PPPDB.Remove(CA);
                _PPPDB.SaveChanges();
            }
            else
            {
                Console.WriteLine($"City Admin with id {Id} doesn't exist");
                return;
            }
        }

        public IEnumerable<CityAdmin1> ReadInCityAdmin()
        {
            var cityAdmin = from CA in _PPPDB.CityAdmin
                        select Mappings.MapCityAdmin.Map(CA);

            return cityAdmin;
        }

        public void UpdateCityAdmin(CityAdmin1 CityAdmin)
        {
            throw new NotImplementedException();
        }
    }
}
