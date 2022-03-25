using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.DBSteps;
using RestSharpNetCoreTemplate.Helpers;
using RestSharpNetCoreTemplate.Requests.Issue;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Issues
{
    [TestFixture]
    public class CreateAnIssueNoteTest : TestBase
    {
        
        public static IEnumerable CreateAnIssueNote()
        {
            return GeneralHelpers.ReturnCSVData(GeneralHelpers.ReturnProjectPath() + "DataDriven/CreateNote.csv");
        }
        
        [Test, TestCaseSource("CreateAnIssueNote")]
        public void AddNoteissueValido(ArrayList testData)
        {

            List<string> issue_id = SolicitacaoDBSteps.RetornaIdProblemaDB();

            string id_issue = issue_id [0];
            string text = testData[0].ToString();
            string nameView_state = "public";
           
            CreateAnIssueNoteRequest createAnIssueNoteRequest = new CreateAnIssueNoteRequest(id_issue);
            createAnIssueNoteRequest.SetJsonBody(text, nameView_state);

            IRestResponse<dynamic> response = createAnIssueNoteRequest.ExecuteRequest();
            Assert.AreEqual(System.Net.HttpStatusCode.Created, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }

        [Test, TestCaseSource("CreateAnIssueNote")]
        public void AddNoteInvalido(ArrayList testData)
        {

            List<string> issue_id = SolicitacaoDBSteps.RetornaIdProblemaDB();

            string id_issue = issue_id[0];
            string text = testData[0].ToString();
            string nameView_state = string.Empty;

            CreateAnIssueNoteRequest createAnIssueNoteRequest = new CreateAnIssueNoteRequest(id_issue);
            createAnIssueNoteRequest.SetJsonBody(text, nameView_state);

            IRestResponse<dynamic> response = createAnIssueNoteRequest.ExecuteRequest();
            Assert.AreEqual(System.Net.HttpStatusCode.BadRequest, response.StatusCode);

        }

        [Test]
        public void AddDateInvalido()
        {
            string id_issue ="ABC";
            string text = "Teste";
            string nameView_state = "public";

            CreateAnIssueNoteRequest createAnIssueNoteRequest = new CreateAnIssueNoteRequest(id_issue);
            createAnIssueNoteRequest.SetJsonBody(text, nameView_state);

            IRestResponse<dynamic> response = createAnIssueNoteRequest.ExecuteRequest();
            Assert.AreEqual(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);

        }

        [Test]
        public void AddIdIssueInvalido()
        {
            string id_issue = "0";
            string text = "Teste";
            string nameView_state = "public";

            CreateAnIssueNoteRequest createAnIssueNoteRequest = new CreateAnIssueNoteRequest(id_issue);
            createAnIssueNoteRequest.SetJsonBody(text, nameView_state);

            IRestResponse<dynamic> response = createAnIssueNoteRequest.ExecuteRequest();
            Assert.AreEqual(System.Net.HttpStatusCode.BadRequest, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);

        }

        [Test]
        public void AddNameViewInvalido()
        {
            List<string> issue_id = SolicitacaoDBSteps.RetornaIdProblemaDB();

            string id_issue = issue_id[0];
            string text = "Teste";
            string nameView_state = string.Empty;

            CreateAnIssueNoteRequest createAnIssueNoteRequest = new CreateAnIssueNoteRequest(id_issue);
            createAnIssueNoteRequest.SetJsonBody(text, nameView_state);

            IRestResponse<dynamic> response = createAnIssueNoteRequest.ExecuteRequest();
            Assert.AreEqual(System.Net.HttpStatusCode.BadRequest, response.StatusCode);

        }

        [Test]
        public void AddTextInvalido()
        {
            List<string> issue_id = SolicitacaoDBSteps.RetornaIdProblemaDB();

            string id_issue = issue_id[0];
            string text = "";
            string nameView_state = "public";

            CreateAnIssueNoteRequest createAnIssueNoteRequest = new CreateAnIssueNoteRequest(id_issue);
            createAnIssueNoteRequest.SetJsonBody(text, nameView_state);

            IRestResponse<dynamic> response = createAnIssueNoteRequest.ExecuteRequest();
            Assert.AreEqual(System.Net.HttpStatusCode.BadRequest, response.StatusCode);



        }

    }
}