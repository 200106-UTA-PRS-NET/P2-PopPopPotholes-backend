using PopPopPotholesAPI.Domain.Models;
using System;
using Xunit;

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
                //Issue1 Issue = new Issue1()
                //{
                //    IssueId = id,
                //    issueType = issuetype,
                //    severity = severity,
                //    CityId = cityid,
                //    latitude = latitude,
                //    longitude = longitude,
                //    linkImg = linkimg,
                //    issueDescription = issuedescription
                //};
                //Assert.Equal(id, Issue.IssueId);
                //Assert.Equal(issuetype, Issue.issueType);
                //Assert.Equal(severity, Issue.severity);
                //Assert.Equal(cityid, Issue.CityId);
                //Assert.Equal(latitude, Issue.latitude);
                //Assert.Equal(longitude, Issue.longitude);
                //Assert.Equal(linkimg, Issue.linkImg);
                //Assert.Equal(issuedescription, Issue.issueDescription);
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
                //City1 City = new City1()
                //{
                //    CityId = id,
                //    cityName = cityname,
                //    countyName = countyname,
                //    stateName = statename,
                //    countryName = countryname
                //};
                //Assert.Equal(id, City.CityId);
                //Assert.Equal(cityname, City.cityName);
                //Assert.Equal(countyname, City.countyName);
                //Assert.Equal(statename, City.stateName);
                //Assert.Equal(countryname, City.countryName);
            }
        }


        [Theory]
        [InlineData(1, "jmastaice", "password", "hey@email.com", "1231231234", 123123, "1")]
        public void CityAdmin1Model(int id, string username,
                        string userpass, string email,
                        string phone, int keytocity,
                        string acctenabled)
        {
            //CityAdmin1 CityAdmin = new CityAdmin1()
            //{
            //    CityId = id,
            //    userName = username,
            //    userPass = userpass,
            //    email = email,
            //    phone = phone,
            //    keyToCity = keytocity,
            //    acctEnabled = acctenabled
            //};
            //Assert.Equal(id, CityAdmin.CityId);
            //Assert.Equal(username, CityAdmin.userName);
            //Assert.Equal(userpass, CityAdmin.userPass);
            //Assert.Equal(email, CityAdmin.email);
            //Assert.Equal(phone, CityAdmin.phone);
            //Assert.Equal(keytocity, CityAdmin.keyToCity);
            //Assert.Equal(acctenabled, CityAdmin.acctEnabled);
        }





    }
}
