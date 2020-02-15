using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PopPopLib.UseModels
{
    public class Issue1
    {
        public int IssueId { get; set; }
        public DateTime? IssueTimeStamp { get; set; }
        [Required]
        public string IssueType { get; set; }
        [Required]
        public string Severity { get; set; }
        [Required]
        public int? CityId { get; set; }
        [Required]
        public decimal Latitude { get; set; }
        [Required]
        public decimal Longitude { get; set; }
        public string LinkImg { get; set; }
        [Required]
        public string IssueDescription { get; set; }
        public string IssueStatus { get; set; }
        public int? IssueUpvotes { get; set; }
    }
}
