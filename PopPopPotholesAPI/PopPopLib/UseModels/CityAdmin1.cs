using System;
using System.Collections.Generic;
using System.Text;

namespace PopPopLib.UseModels
{
    public class CityAdmin1
    {
        public int AdminId { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int KeyToCity { get; set; }
        public DateTime? LockOut { get; set; }
        public string AcctEnabled { get; set; }
    }
}
