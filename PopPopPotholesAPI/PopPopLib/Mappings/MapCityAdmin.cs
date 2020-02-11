using System;
using System.Collections.Generic;
using System.Text;
using PopPopLib.UseModels;

namespace PopPopLib.Mappings
{
    public class MapCityAdmin
    {
        public static CityAdmin1 Map(Models.CxOrder CA)
        {
            return new CityAdmin1()
            {
                CityId = CA.Id,
                userName = CA.userName,
                userPass = CA.userPass,
                email = CA.email,
                phone = CA.phone,
                keyToCity = CA.keyToCity,
                lockOut = CA.lockOut,
                acctEnabled = CA.acctEnabled
            };
        }

        public static Models.CxOrder Map(CityAdmin1 CA)
        {
            return new Models.CxOrder()
            {
                Id = CA.CityId,
                userName = CA.userName,
                userPass = CA.userPass,
                email = CA.email,
                phone = CA.phone,
                keyToCity = CA.keyToCity,
                lockOut = CA.lockOut,
                acctEnabled = CA.acctEnabled
            };

        }
    }
}
