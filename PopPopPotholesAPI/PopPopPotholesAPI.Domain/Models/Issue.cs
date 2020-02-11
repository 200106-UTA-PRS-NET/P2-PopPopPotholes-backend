using System;
using System.Collections.Generic;

namespace PopPopPotholesAPI.Domain.Models
{
    public partial class Issue
    {
        public int Id { get; set; }
        public DateTime? IssueTimestamp { get; set; }
        public string IssueType { get; set; }
        public string Severity { get; set; }
        public int? CityId { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string LinkImg { get; set; }
        public string IssueDesc { get; set; }
        public string IssueStatus { get; set; }
        public int? IssueUpvotes { get; set; }

        public virtual City City { get; set; }
    }
}
