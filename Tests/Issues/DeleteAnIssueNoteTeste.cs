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
    public class DeleteAnIssueNoteTeste: TestBase
    {
        [Test]
        [Parallelizable]
        public void DeleteAnIssueInvalidNote0()
        {
            List<string> idProblemaIdNote = SolicitacaoDBSteps.RetornaIdProjetoNoteDB();
            string issue_id = idProblemaIdNote[0];
            string issue_note_id = "0";

            DeleteAnIssueNoteRequest deleteAnIssueNoteRequest = new DeleteAnIssueNoteRequest(issue_id, issue_note_id);
            IRestResponse<dynamic> response = deleteAnIssueNoteRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }

        [Test]
        [Parallelizable]
        public void DeleteAnIssueInvalid()
        {
            List<string> idProblemaIdNote = SolicitacaoDBSteps.RetornaIdProjetoNoteDB();
            string issue_id = idProblemaIdNote[0];
            string issue_note_id = "4444444a";

            DeleteAnIssueNoteRequest deleteAnIssueNoteRequest = new DeleteAnIssueNoteRequest(issue_id, issue_note_id);
            IRestResponse<dynamic> response = deleteAnIssueNoteRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.NotFound, response.StatusCode);
            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }

        [Test]
        [Parallelizable]
        public void DeleteAnIssueNote()
        {
            List<string> idProblemaIdNote = SolicitacaoDBSteps.RetornaIdProjetoNoteDB();
            string issue_id = idProblemaIdNote[1];
            string issue_note_id = idProblemaIdNote[0];

            DeleteAnIssueNoteRequest deleteAnIssueNoteRequest = new DeleteAnIssueNoteRequest(issue_id, issue_note_id);
            IRestResponse<dynamic> response = deleteAnIssueNoteRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }
      
    }
}
