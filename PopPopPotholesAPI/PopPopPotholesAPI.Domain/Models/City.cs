using System;
using System.Collections.Generic;

namespace PopPopPotholesAPI.Domain.Models
{
    public partial class City
    {
        public City()
        {
            CityAdmin = new HashSet<CityAdmin>();
            Issue = new HashSet<Issue>();
        }

        public int Id { get; set; }
        public string CityName { get; set; }
        public string CountyName { get; set; }
        public string StateName { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<CityAdmin> CityAdmin { get; set; }
        public virtual ICollection<Issue> Issue { get; set; }
    }
}
