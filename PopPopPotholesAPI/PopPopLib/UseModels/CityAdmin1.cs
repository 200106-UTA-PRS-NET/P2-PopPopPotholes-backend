using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PopPopLib.UseModels
{
    public class CityAdmin1
    {
        public int AdminId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserPass { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid Email Expression")]
        public string Email { get; set; }
        [RegularExpression(@"^(([(][0-9][0-9][0-9][)])|([0-9][0-9][0-9])|([0-9][0-9][0-9][-]))(([0-9][0-9][0-9][-])|([0-9][0-9][0-9]))[0-9][0-9][0-9][0-9]$", ErrorMessage = "Invalid Phone Expression")]
        public string Phone { get; set; }
        public int KeyToCity { get; set; }
        [Display(Name = "Lock Out")]
        public DateTime? LockOut { get; set; }
        public string AcctEnabled { get; set; }
    }
}
