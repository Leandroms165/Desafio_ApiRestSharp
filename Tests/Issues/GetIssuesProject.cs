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
    public class GetIssuesProject : TestBase
    {
        [Test]
        [Parallelizable]
        public void GetIssueProj()
        {
            List<string> project_id = SolicitacaoDBSteps.RetornaIDProject();
            string id_project = project_id[0];

            List<string> id = SolicitacaoDBSteps.RetornaIdProblemaDB();
            string id_project2 = id[0];

            GetIssuesProjectRequest getIssuesProjectRequest = new GetIssuesProjectRequest(id_project);
            IRestResponse<dynamic> response = getIssuesProjectRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual(id_project2, response.Data["issues"][0]["id"].ToString());

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }
    }
}
