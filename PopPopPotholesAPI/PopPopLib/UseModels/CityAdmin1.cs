using System;
using System.Collections.Generic;
using System.Text;

namespace PopPopLib.UseModels
{
    public class CityAdmin1
    {
        public int CityId { get; set; }
        public string userName { get; set; }
        public string userPass { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public int keyToCity { get; set; }
        public DateTime? lockOut { get; set; }
        public string acctEnabled { get; set; }
    }
}
