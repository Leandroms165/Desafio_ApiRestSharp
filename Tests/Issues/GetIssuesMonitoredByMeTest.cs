using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests.Issue;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Issues
{
    public class GetIssuesMonitoredByMeTest : TestBase
    {
        [Test]
        [Parallelizable]
        public void GetIssuesMonitoredByMeValid()
        {
            string filter_id = "monitored";

            GetIssuesMonitoredByMeRequest getIssuesMonitoredByMeRequest = new GetIssuesMonitoredByMeRequest(filter_id);
            IRestResponse<dynamic> response = getIssuesMonitoredByMeRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }

        [Test]
        [Parallelizable]
        public void GetIssuesMonitoredByMeInValid()
        {
            string filter_id = "Testes";

            GetIssuesMonitoredByMeRequest getIssuesMonitoredByMeRequest = new GetIssuesMonitoredByMeRequest(filter_id);
            IRestResponse<dynamic> response = getIssuesMonitoredByMeRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }
    }
}
