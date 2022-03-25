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
    public class ResetUserPasswordTest : TestBase
    {
        [Test]
        public void ResetUseraPassword()
        {
            string user_id = "25";

            ResetUserPasswordRequest resetUserPasswordRequest = new ResetUserPasswordRequest(user_id);
            IRestResponse<dynamic> response = resetUserPasswordRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.NotFound, response.StatusCode);


            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }
    }
}
