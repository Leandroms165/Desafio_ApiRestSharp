using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.DBSteps;
using RestSharpNetCoreTemplate.Requests;
using System;
using System.Collections.Generic;

namespace RestSharpNetCoreTemplate.Issues
{
    public class GetIssueTest : TestBase
    {
       [Test]
       [Parallelizable]
        public void GetIssueValido()
        {
            List<string> id = SolicitacaoDBSteps.RetornaIdProblemaDB();
            string id_issue = id[0];

            GetIssueRequest getIssueRequest = new GetIssueRequest(id_issue);
            IRestResponse<dynamic> response = getIssueRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual(id_issue, response.Data["issues"][0]["id"].ToString());

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }

        [Test]
        [Parallelizable]
        public void GetIssueInvalido()
        {
            string id_issue = "332";

            GetIssueRequest getIssueRequest = new GetIssueRequest(id_issue);
            IRestResponse<dynamic> response = getIssueRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.NotFound, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }

        //[Test]
        //public void TesteaSelect()
        //{
            
        //    Console.WriteLine(SolicitacaoDBSteps.Select()[1]);
        //}
    }
}
