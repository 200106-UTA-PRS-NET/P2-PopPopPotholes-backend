using PopPopPotholesAPI.Domain.Models;
using System;
using Xunit;
using PopPopLib.UseModels;

namespace PopPopPotholesAPI.Test
{
    public class UnitTest1
    {

       

        [Fact]
        public void Test1()
        {

        }

        public class IssueModelTest
        {
            [Theory]
            [InlineData(1, "nuesance", "severe", 123123, 123123123.12, 1231231231.12,
                "imglocation", "IcantstandloudmusiclolcatHeeeeyyyyyeyyyyeyyyeyyaaaaa")]
            public void Issue1Model(int id,
                            string issuetype, string severity,
                            int cityid, decimal latitude, decimal longitude,
                            string linkimg, string issuedescription)
            {
                Issue1 Issue = new Issue1()
                {
                    IssueId = id,
                    IssueType = issuetype,
                    Severity = severity,
                    CityId = cityid,
                    Latitude = latitude,
                    Longitude = longitude,
                    LinkImg = linkimg,
                    IssueDescription = issuedescription
                };
                Assert.Equal(id, Issue.IssueId);
                Assert.Equal(issuetype, Issue.IssueType);
                Assert.Equal(severity, Issue.Severity);
                Assert.Equal(cityid, Issue.CityId);
                Assert.Equal(latitude, Issue.Latitude);
                Assert.Equal(longitude, Issue.Longitude);
                Assert.Equal(linkimg, Issue.LinkImg);
                Assert.Equal(issuedescription, Issue.IssueDescription);
            }
        }
        public class CityModelTest
        {
            [Theory]
            [InlineData(1, "Tucson", "Pima", "AZ", "United States")]
            public void City1Model(int id, string cityname,
                                    string countyname, string statename,
                                    string countryname)
            {
                City1 City = new City1()
                {
                    CityId = id,
                    cityName = cityname,
                    countyName = countyname,
                    stateName = statename,
                    countryName = countryname
                };
                Assert.Equal(id, City.CityId);
                Assert.Equal(cityname, City.cityName);
                Assert.Equal(countyname, City.countyName);
                Assert.Equal(statename, City.stateName);
                Assert.Equal(countryname, City.countryName);
            }
        }


        [Theory]
        [InlineData("jmastaice", "password", "hey@email.com", "1231231234", 123123, "1")]
        public void CityAdmin1Model(string username,
                        string userpass, string email,
                        string phone, int keytocity,
                        string acctenabled)
        {
            CityAdmin1 CityAdmin = new CityAdmin1()
            {
                UserName = username,
                UserPass = userpass,
                Email = email,
                Phone = phone,
                KeyToCity = keytocity,
                AcctEnabled = acctenabled
            };
            Assert.Equal(username, CityAdmin.UserName);
            Assert.Equal(userpass, CityAdmin.UserPass);
            Assert.Equal(email, CityAdmin.Email);
            Assert.Equal(phone, CityAdmin.Phone);
            Assert.Equal(keytocity, CityAdmin.KeyToCity);
            Assert.Equal(acctenabled, CityAdmin.AcctEnabled);
        }


        [Fact]
        public void CityAdminRepoGetTest()
        {

        }




    }
}
