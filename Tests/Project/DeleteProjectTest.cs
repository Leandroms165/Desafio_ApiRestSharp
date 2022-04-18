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
     public class DeleteProjectTest : TestBase
    {
        [Test]
        [Parallelizable]
        public void DadosValidos()
        {
            List<string> ProjectCreate = SolicitacaoDBSteps.RetornaIDProject();
            string project_id = ProjectCreate[0];

            DeleteProjectRequest deleteProjectRequest = new DeleteProjectRequest(project_id);
            IRestResponse<dynamic> response = deleteProjectRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);

        }
       
        [Test]
        [Parallelizable]
        public void DataInvalid()
        {
            string project_id = "A95500";

            DeleteProjectRequest deleteProjectRequest = new DeleteProjectRequest(project_id);
            IRestResponse<dynamic> response = deleteProjectRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.BadRequest, response.StatusCode);



        }


    }
}
