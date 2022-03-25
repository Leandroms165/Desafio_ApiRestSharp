using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.DBSteps;
using RestSharpNetCoreTemplate.Requests.Issue;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Issues
{
    public class MonitorAnIssueTest : TestBase
    {
        [Test]
        [Parallelizable]
        public void DateValid()
        {
            List<string> idIssue = SolicitacaoDBSteps.RetornaIdProblemaDB();
            string issue_id = idIssue[0];

            MonitorAnIssueRequest monitorAnIssueRequest = new MonitorAnIssueRequest(issue_id);
            IRestResponse<dynamic> response = monitorAnIssueRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.Created, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);

            Console.WriteLine(SolicitacaoDBSteps.RetornaIdProblemaDB()[0]);
        }

        [Test]
        [Parallelizable]
        public void DataInvalid()
        {
            
            string issue_id = "0";

            MonitorAnIssueRequest monitorAnIssueRequest = new MonitorAnIssueRequest(issue_id);
            IRestResponse<dynamic> response = monitorAnIssueRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.BadRequest, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);

        }
    }
}
