using System;
using System.Collections.Generic;
using System.Text;
using PopPopLib.UseModels;
using PopPopLib.PPAbstracts;
using PopPopPotholesAPI.Domain.Models;
using System.Linq;


namespace PopPopLib.PPRepos
{
    public class CityRepository : IRepositoryCity<City1>
    {
        PopPopPotholesDbContext _PPPDB;
        public CityRepository(PopPopPotholesDbContext PPPDB)
        {
            _PPPDB = PPPDB;
        }


        public void CreateCity(City1 City)
        {
            _PPPDB.Add(Mappings.MapCity.Map(City));// this will generate insertMapper.Map(customer)
            _PPPDB.SaveChanges();// this will execute the above generate insert query
        }

        public void DeleteCity(int Id)
        {
            var City = _PPPDB.City.FirstOrDefault(Cx => Cx.Id == Id);
            if (City.Id == Id)
            {
                _PPPDB.Remove(City);
                _PPPDB.SaveChanges();
            }
            else
            {
                Console.WriteLine($"City with id {Id} doesn't exist");
                return;
            }
        }

        public IEnumerable<City1> ReadInCity()
        {
            var getCity = from IX in _PPPDB.City
                           select Mappings.MapCity.Map(IX);
            return getCity;
        }

        public void UpdateCity(City1 City)
        {
            throw new NotImplementedException();
        }
    }
}
