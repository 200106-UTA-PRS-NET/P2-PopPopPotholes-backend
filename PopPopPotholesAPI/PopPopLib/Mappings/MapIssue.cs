using PopPopLib.UseModels;
using System;
using System.Collections.Generic;
using System.Text;
using PopPopPotholesAPI.Domain.Models;

namespace PopPopLib.Mappings
{
    public class MapIssue
    {
        public static Issue1 Map(Issue IX)
        {
            return new Issue1()
            {
                IssueId = IX.Id,
                issueTimeStamp = IX.IssueTimestamp,
                issueType = IX.IssueType,
                severity = IX.Severity,
                CityId = IX.CityId,
                latitude = IX.Latitude,
                longitude = IX.Longitude,
                linkImg = IX.LinkImg,
                issueDescription = IX.IssueDesc,
                issueStatus = IX.IssueStatus,
                issueUpvotes = IX.IssueUpvotes
            };
        }

        public static Issue Map(Issue1 IX)
        {
            return new Issue()
            {
                Id = IX.IssueId,
                IssueTimestamp = IX.issueTimeStamp,
                IssueType = IX.issueType,
                Severity = IX.severity,
                CityId = IX.CityId,
                Latitude = IX.latitude,
                Longitude = IX.longitude,
                LinkImg = IX.linkImg,
                IssueDesc = IX.issueDescription,
                IssueStatus = IX.issueStatus,
                IssueUpvotes = IX.issueUpvotes
                
            };
        }
    }
}
