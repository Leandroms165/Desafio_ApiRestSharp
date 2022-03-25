using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Users
{
    public class GetMyUserInfoTest: TestBase
    {
        [Test]
        public void GetMyUserInfo()
        {
            GetMyUserInfoRequest getMyUserInfoRequest = new GetMyUserInfoRequest();
            IRestResponse<dynamic> response = getMyUserInfoRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }
    }
}
