using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.DBSteps;
using RestSharpNetCoreTemplate.Requests.Issue_Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Issues
{
    public class UpdateAnIssueTest : TestBase
    {
        [Test]
        [Parallelizable]
        public void DadosValidos()
        {
            List<string> id = SolicitacaoDBSteps.RetornaIdProblemaDB();
           
            string issue_id = id[0];

            string summary = "teste api";

            string description = "novo erro encontrado";

            UpdateAnIssueResquest updateAnIssueResquest = new UpdateAnIssueResquest(issue_id);
            updateAnIssueResquest.SetJsonBody(summary, description);

            IRestResponse <dynamic> response = updateAnIssueResquest.ExecuteRequest();
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
          
            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);

        }

        [Test]
        [Parallelizable]
        public void DadosInvalidos()
        {
            string issue_id = "00000";

            string summary = "teste api";

            string description = "novo erro encontrado";

            UpdateAnIssueResquest updateAnIssueResquest = new UpdateAnIssueResquest(issue_id);
            updateAnIssueResquest.SetJsonBody(summary, description);

            IRestResponse<dynamic> response = updateAnIssueResquest.ExecuteRequest();
            Assert.AreEqual(System.Net.HttpStatusCode.NotFound, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);

        }
    }
}
