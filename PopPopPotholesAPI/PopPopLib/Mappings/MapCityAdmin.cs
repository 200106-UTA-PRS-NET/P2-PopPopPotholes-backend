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
                AdminId = CA.Id,
                UserName = CA.UserName,
                UserPass = CA.UserPass,
                Email = CA.Email,
                Phone = CA.Phone,
                KeyToCity = CA.KeyToCity,
                LockOut = CA.LockOut,
                AcctEnabled = CA.AcctEnabled
            };
        }

        public static PopPopPotholesAPI.Domain.Models.CityAdmin Map(CityAdmin1 CA)
        {
            return new PopPopPotholesAPI.Domain.Models.CityAdmin()
            {
                Id = CA.AdminId,
                UserName = CA.UserName,
                UserPass = CA.UserPass,
                Email = CA.Email,
                Phone = CA.Phone,
                KeyToCity = CA.KeyToCity,
                LockOut = CA.LockOut,
                AcctEnabled = CA.AcctEnabled
            };

        }
    }
}
