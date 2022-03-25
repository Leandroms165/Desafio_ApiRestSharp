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
    public class GetUnassignedIssuesTest : TestBase
    {
        [Test]
        public void DadosValidos()
        {
            string id_filter = "unassigned";

            GetUnassignedIssuesRequest getUnassignedIssuesRequest = new GetUnassignedIssuesRequest(id_filter);
            IRestResponse<dynamic> response = getUnassignedIssuesRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }

        [Test]
        public void DadosInvalidos()
        {
            string id_filter = "tesste01";

            GetUnassignedIssuesRequest getUnassignedIssuesRequest = new GetUnassignedIssuesRequest(id_filter);
            IRestResponse<dynamic> response = getUnassignedIssuesRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }
    }
}
