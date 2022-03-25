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
    public class GetIssuesReportedByMeTest: TestBase
    {
        [Test]
        [Parallelizable]
        public void DadosValidos()
        {
            string id_filter = "reported";

            GetIssuesReportedByMeRequest getIssuesReportedByMeRequest = new GetIssuesReportedByMeRequest(id_filter);
            IRestResponse<dynamic> response = getIssuesReportedByMeRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }

        [Test]
        public void DadosInvalidos()
        {
            string id_filter = "desafio785";
            

            GetIssuesReportedByMeRequest getIssuesReportedByMeRequest = new GetIssuesReportedByMeRequest(id_filter);
            IRestResponse<dynamic> response = getIssuesReportedByMeRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
            
            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }
    }
}
