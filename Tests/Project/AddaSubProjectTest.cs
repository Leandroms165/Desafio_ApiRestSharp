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
    public class AddaSubProjectTest : TestBase
    {
        [Test]
        [Parallelizable]
        public void AddaSubProjectValid()
        {
            List<string> project_name = SolicitacaoDBSteps.RetornaIDProject();
            string project_id = project_name[0];

            string name = "Novosub";

            AddaSubProjectRequest addaSubProjectRequest = new AddaSubProjectRequest(project_id);
            addaSubProjectRequest.SetJsonBody(name);

            IRestResponse<dynamic> response = addaSubProjectRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.NotFound, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);

        }
        [Test]
        [Parallelizable]
        public void AddaSubProjectInValid()
        {
            List<string> project_name = SolicitacaoDBSteps.RetornaIDProject();
            string nameProject = project_name[0];

            string name = "Teste";

            AddaSubProjectRequest addaSubProjectRequest = new AddaSubProjectRequest(nameProject);
            addaSubProjectRequest.SetJsonBody(name);

            IRestResponse<dynamic> response = addaSubProjectRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.NotFound, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);

        }

    }
}
