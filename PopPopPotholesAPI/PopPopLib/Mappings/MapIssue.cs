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
                IssueTimeStamp = IX.IssueTimestamp,
                IssueType = IX.IssueType,
                Severity = IX.Severity,
                CityId = IX.CityId,
                Latitude = IX.Latitude,
                Longitude = IX.Longitude,
                LinkImg = IX.LinkImg,
                IssueDescription = IX.IssueDesc,
                IssueStatus = IX.IssueStatus,
                IssueUpvotes = IX.IssueUpvotes
            };
        }

        public static Issue Map(Issue1 IX)
        {
            return new Issue()
            {
                Id = IX.IssueId,
                IssueTimestamp = IX.IssueTimeStamp,
                IssueType = IX.IssueType,
                Severity = IX.Severity,
                CityId = IX.CityId,
                Latitude = IX.Latitude,
                Longitude = IX.Longitude,
                LinkImg = IX.LinkImg,
                IssueDesc = IX.IssueDescription,
                IssueStatus = IX.IssueStatus,
                IssueUpvotes = IX.IssueUpvotes
            };
        }
    }
}
