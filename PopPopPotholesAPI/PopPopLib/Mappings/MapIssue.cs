using PopPopLib.UseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PopPopLib.Mappings
{
    public class MapIssue
    {
        public static Issue1 Map(Models.CxOrder IX)
        {
            return new Issue1()
            {
                IssueId = IX.Id,
                issueTimeStamp = IX.issueTimeStamp,
                issueType = IX.issueType,
                severity = IX.severity,
                CityId = IX.CityId,
                latitude = IX.latitude,
                longitude = IX.longitude,
                linkImg = IX.linkImg,
                issueDescription = IX.issueDescription
            };
        }

        public static Models.CxOrder Map(Issue1 IX)
        {
            return new Models.CxOrder()
            {
                Id = IX.IssueId,
                issueTimeStamp = IX.issueTimeStamp,
                issueType = IX.issueType,
                severity = IX.severity,
                CityId = IX.CityId,
                latitude = IX.latitude,
                longitude = IX.longitude,
                linkImg = IX.linkImg,
                issueDescription = IX.issueDescription
            };
        }
    }
}
