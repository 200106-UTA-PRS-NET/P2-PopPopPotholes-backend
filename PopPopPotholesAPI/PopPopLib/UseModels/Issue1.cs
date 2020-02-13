using System;
using System.Collections.Generic;
using System.Text;

namespace PopPopLib.UseModels
{
    public class Issue1
    {
        public int IssueId { get; set; }
        public DateTime? IssueTimeStamp { get; set; }
        public string IssueType { get; set; }
        public string Severity { get; set; }
        public int? CityId { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string LinkImg { get; set; }
        public string IssueDescription { get; set; }
        public string IssueStatus { get; set; }
        public int? IssueUpvotes { get; set; }
    }
}
