using System;
using System.Collections.Generic;

namespace PopPopPotholesAPI.Domain.Models
{
    public partial class CityAdmin
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int KeyToCity { get; set; }
        public DateTime? LockOut { get; set; }
        public string AcctEnabled { get; set; }

        public virtual City KeyToCityNavigation { get; set; }
    }
}
