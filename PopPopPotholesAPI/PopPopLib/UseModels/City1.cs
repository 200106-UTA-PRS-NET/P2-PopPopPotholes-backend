using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PopPopLib.UseModels
{
    public class City1
    {
        public int CityId { get; set; }
        public string cityName { get; set; }
        public string countyName { get; set; }
        [Required]
        public string stateName { get; set; }
        [Required]
        public string countryName { get; set; }
    }
}
