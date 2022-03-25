using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests.Lang;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Lang
{
    public class GetLocalizedStringTest : TestBase
    {
        [Test]
        [Parallelizable]
        public void GetLocalizedstringValid()
        {
            string desc = "all_projects";

            GetLocalizedStringRequest getLocalizedStringRequest = new GetLocalizedStringRequest(desc);
            IRestResponse<dynamic> response = getLocalizedStringRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }

        [Test]
        [Parallelizable]
        public void GetLocalizedstringInvalid()
        {
            string desc = "invalid";

            GetLocalizedStringRequest getLocalizedStringRequest = new GetLocalizedStringRequest(desc);
            IRestResponse<dynamic> response = getLocalizedStringRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }
    }
}
