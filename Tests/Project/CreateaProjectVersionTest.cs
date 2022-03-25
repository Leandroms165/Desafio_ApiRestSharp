using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.DBSteps;
using RestSharpNetCoreTemplate.Helpers;
using RestSharpNetCoreTemplate.Projects;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Project
{
    public class CreateaProjectVersionTest: TestBase
    {
        [Test]
        public void CreateaProjectVersionValid()
        {
            List<string> id_project = SolicitacaoDBSteps.RetornaIDProject();
            string project_id = id_project[0];

            string nameVersion = "v." + GeneralHelpers.ReturnStringWithRandomNumbers(1);

            CreateaProjectVersionRequest createaProjectVersionRequest = new CreateaProjectVersionRequest(project_id);
            createaProjectVersionRequest.SetJsonBody(nameVersion);

            IRestResponse<dynamic> response = createaProjectVersionRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.NoContent, response.StatusCode);

        }

        [Test]
        public void CreateaProjectVersionInvalid()
        {
            
            string project_id = "";

            string nameVersion = "";

            CreateaProjectVersionRequest createaProjectVersionRequest = new CreateaProjectVersionRequest(project_id);
            createaProjectVersionRequest.SetJsonBody(nameVersion);

            IRestResponse<dynamic> response = createaProjectVersionRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.NotFound, response.StatusCode);

        }

        [Test]
        public void CreateaProjectVersionInvaliProject()
        {

            string project_id = "aaaa";

            string nameVersion = "v." + GeneralHelpers.ReturnStringWithRandomNumbers(1);

            CreateaProjectVersionRequest createaProjectVersionRequest = new CreateaProjectVersionRequest(project_id);
            createaProjectVersionRequest.SetJsonBody(nameVersion);

            IRestResponse<dynamic> response = createaProjectVersionRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.BadRequest, response.StatusCode);

        }
    }
}
