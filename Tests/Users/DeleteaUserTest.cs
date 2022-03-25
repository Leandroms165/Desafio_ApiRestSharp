using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.DBSteps;
using RestSharpNetCoreTemplate.Requests.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Users
{
    public class DeleteaUserTest : TestBase
    {
        [Test]
        public void DeleteaUserValid()
        {
            List<string> user = SolicitacaoDBSteps.RetornaIdUser();

            string id_user = user[0];

            DeleteaUserRequest deleteaUserRequest = new DeleteaUserRequest(id_user);
            IRestResponse<dynamic> response = deleteaUserRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.NoContent, response.StatusCode);

        }
        [Test]
        public void DeleteUserInvalid()
        {
            string id_user = "0000";

            DeleteaUserRequest deleteaUserRequest = new DeleteaUserRequest(id_user);
            IRestResponse<dynamic> response = deleteaUserRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }
        
    }
}
