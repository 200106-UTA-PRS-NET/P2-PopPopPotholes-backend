using System;
using System.Collections.Generic;
using System.Text;
using PopPopLib.UseModels;

namespace PopPopLib.Mappings
{
    public class MapCityAdmin
    {
        public static CityAdmin1 Map(PopPopPotholesAPI.Domain.Models.CityAdmin CA)
        {
            return new CityAdmin1()
            {
                CityId = CA.Id,
                userName = CA.UserName,
                userPass = CA.UserPass,
                email = CA.Email,
                phone = CA.Phone,
                keyToCity = CA.KeyToCity,
                lockOut = CA.LockOut,
                acctEnabled = CA.AcctEnabled
            };
        }

        public static PopPopPotholesAPI.Domain.Models.CityAdmin Map(CityAdmin1 CA)
        {
            return new PopPopPotholesAPI.Domain.Models.CityAdmin()
            {
                Id = CA.CityId,
                UserName = CA.userName,
                UserPass = CA.userPass,
                Email = CA.email,
                Phone = CA.phone,
                KeyToCity = CA.keyToCity,
                LockOut = CA.lockOut,
                AcctEnabled = CA.acctEnabled
            };

        }
    }
}
