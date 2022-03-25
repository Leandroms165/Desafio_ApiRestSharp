using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.DBSteps;
using RestSharpNetCoreTemplate.Helpers;
using RestSharpNetCoreTemplate.Requests.Projects;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Project
{
    [TestFixture]
    public class CreateProjectTest : TestBase
    {
        [Test]
        public void CreateProjectValido()
        {
            string name = 1 + "Santander" + GeneralHelpers.ReturnStringWithRandomNumbers(2);
            string nameStatus = "development";
            string labelStatus = "development";
            string description = "Open Baking";
            string file_path = "/tmp/";
            string nameView_state = "public";
            string labelView_state = "public";

            CreateProjectRequest createProjectRequest = new CreateProjectRequest();
            createProjectRequest.SetJasoBody(name, nameStatus, labelStatus, description, file_path, nameView_state, labelView_state);

            IRestResponse<dynamic> response = createProjectRequest.ExecuteRequest();
            Assert.AreEqual(System.Net.HttpStatusCode.Created, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }

        [Test]
        public void CreateProjectInvalido()
        {
            List<string> ProjectCreated = SolicitacaoDBSteps.RetornaNameProject();

            string name = ProjectCreated[0];
            string nameStatus = "development";
            string labelStatus = "development";
            string description = "Open Baking";
            string file_path = "/tmp/";
            string nameView_state = "public";
            string labelView_state = "public";

            CreateProjectRequest createProjectRequest = new CreateProjectRequest();
            createProjectRequest.SetJasoBody(name, nameStatus, labelStatus, description, file_path, nameView_state, labelView_state);

            IRestResponse<dynamic> response = createProjectRequest.ExecuteRequest();
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);

           
        }
    }
}
