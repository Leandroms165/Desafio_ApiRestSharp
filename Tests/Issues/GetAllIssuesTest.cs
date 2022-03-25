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
    public  class GetAllIssuesTest: TestBase
    {
        [Test]
        [Parallelizable]
        public void DadosValidos()
        {
            string page_size = "10";
            string page = "1";

            GetAllIssuesRequest getAllIssuesRequest = new GetAllIssuesRequest(page_size, page);
            IRestResponse<dynamic> response = getAllIssuesRequest.ExecuteRequest();


            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }
    }
}
