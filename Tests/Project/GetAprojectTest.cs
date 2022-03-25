using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.DBSteps;
using RestSharpNetCoreTemplate.Requests.Projects;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Project
{
    public class GetAprojectTest : TestBase
    {
        [Test]
        public void GetAprojectValid()
        {
            List<string> project_id = SolicitacaoDBSteps.RetornaIDProject();

            string id_project = project_id[0];

            GetAprojectRequest getAprojectRequest = new GetAprojectRequest(id_project);
            IRestResponse<dynamic> response = getAprojectRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }
      
        [Test]
        public void GetAprojectInValid()
        {
            

            string id_project = "0778";

            GetAprojectRequest getAprojectRequest = new GetAprojectRequest(id_project);
            IRestResponse<dynamic> response = getAprojectRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.NotFound, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }

    }
}
