using System;
using System.Collections.Generic;
using System.Text;
using PopPopLib.UseModels;

namespace PopPopLib.Mappings
{
    public class MapCity
    {
        public static City1 Map(PopPopPotholesAPI.Domain.Models.City CX)
        {
            return new City1()
            {
                CityId = CX.Id,
                cityName = CX.CityName,
                countyName = CX.CountyName,
                stateName = CX.StateName,
                countryName = CX.CountryName
            };
        }

        public static PopPopPotholesAPI.Domain.Models.City Map(City1 CX)
        {
            return new PopPopPotholesAPI.Domain.Models.City()
            {
                Id = CX.CityId,
                CityName = CX.cityName,
                CountyName = CX.countyName,
                StateName = CX.stateName,
                CountryName = CX.countryName
            };
        }
    }
}
