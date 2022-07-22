using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.DBSteps;
using RestSharpNetCoreTemplate.Requests.Issue_Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Issues
{
    public class DeleteIssueTest : TestBase
    {
        [Test]
        [Parallelizable]
        public void DadosValidos()
        {
            List<string> id = SolicitacaoDBSteps.RetornaIdProblemaDB();
            string id_delete = id[0];

            DeleteIssueRequest deleteIssueRequest = new DeleteIssueRequest(id_delete);
            IRestResponse<dynamic> response = deleteIssueRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.NotFound, response.StatusCode);

        }

        [Test]
        [Parallelizable]
        public void DadosInvalidos()
        {
            string id_delete = "A002177";

            DeleteIssueRequest deleteIssueRequest = new DeleteIssueRequest(id_delete);
            IRestResponse<dynamic> response = deleteIssueRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
