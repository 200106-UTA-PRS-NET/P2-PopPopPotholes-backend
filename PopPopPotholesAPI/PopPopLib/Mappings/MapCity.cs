using System;
using System.Collections.Generic;
using System.Text;
using PopPopLib.UseModels;

namespace PopPopLib.Mappings
{
    public class MapCity
    {
        public static City1 Map(Models.CxOrder CX)
        {
            return new City1()
            {
                CityId = CX.Id,
                cityName = CX.cityName,
                countyName = CX.countyName,
                stateName = CX.stateName,
                countryName = CX.countryName
            };
        }

        public static Models.CxOrder Map(City1 CX)
        {
            return new Models.CxOrder()
            {
                Id = CX.CityId,
                cityName = CX.cityName,
                countyName = CX.countyName,
                stateName = CX.stateName,
                countryName = CX.countryName
            };
        }
    }
}
