using System;
using System.Collections.Generic;
using System.Text;

namespace PopPopLib.UseModels
{
    public class Issue1
    {
        public int IssueId { get; set; }
        public DateTime? issueTimeStamp { get; set; }
        public string issueType { get; set; }
        public string severity { get; set; }
        public int? CityId { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
        public string linkImg { get; set; }
        public string issueDescription { get; set; }
        public string issueStatus { get; set; }
        public int? issueUpvotes { get; set; }
    }
}
