using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.DBSteps;
using RestSharpNetCoreTemplate.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Issues

{
    [TestFixture]
    public class CreateAnIssueTest: TestBase
    {
        [Test]
        public void CreateNewIssueInvalid()
        {
            //arrange
            string summary = "Tela Login";
            string description = "Erro ao editar dados de entrada";
            string name_project = "Not Exist";
            //actions
            CreateIssueRequest createIssueRequest = new CreateIssueRequest();
            createIssueRequest.SetJsonBody(summary, description, name_project);

            IRestResponse<dynamic> response = createIssueRequest.ExecuteRequest();
            Assert.AreEqual(System.Net.HttpStatusCode.BadRequest, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }

        [Test]
        public void CreateNewIssueValid()
        {
           // SolicitacaoDBSteps.InserirProject();

            List<string> name_projec = SolicitacaoDBSteps.RetornaNameProject();
            //arrange
            string summary = "Tela Login";
            string description = "Erro ao editar dados de entrada";
            string name_project = name_projec[0];
            //actions
            CreateIssueRequest createIssueRequest = new CreateIssueRequest();
            createIssueRequest.SetJsonBody(summary, description, name_project);

            IRestResponse<dynamic> response = createIssueRequest.ExecuteRequest();
            Assert.AreEqual(System.Net.HttpStatusCode.Created, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }

    }
}
