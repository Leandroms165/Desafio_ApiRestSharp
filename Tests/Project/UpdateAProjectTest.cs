using DesafioAPI.Requests.Projects;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.DBSteps;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Project
{
    [TestFixture]
    public class UpdateAProjectTest : TestBase
    {
        [Test]
        [Parallelizable]
        public void AlterarProjetoSucesso()
        {
            List<string> id_prject = SolicitacaoDBSteps.RetornaIDProject();
            string project_id = id_prject[0];

            string name = "$nameProject36";

            UpdateAProjectRequest updateAProjectRequest = new UpdateAProjectRequest(project_id);
            updateAProjectRequest.SetJsonBody(name, project_id);

            IRestResponse<dynamic> response = updateAProjectRequest.ExecuteRequest();
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
            //Assert.AreEqual("1", response.Data["id"].ToString());
            
        }

        [Test]
        [Parallelizable]
        public void AlterarProjetoIdInvalid()
        {

            string project_id = "3659";

            string name = "$nameProject6";

            UpdateAProjectRequest updateAProjectRequest = new UpdateAProjectRequest(project_id);
            updateAProjectRequest.SetJsonBody(name, project_id);

            IRestResponse<dynamic> response = updateAProjectRequest.ExecuteRequest();
            Assert.AreEqual(System.Net.HttpStatusCode.NotFound, response.StatusCode);
            //Assert.AreEqual("1", response.Data["id"].ToString());
            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }
    }
}