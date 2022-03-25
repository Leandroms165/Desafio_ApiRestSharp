using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.DBSteps;
using RestSharpNetCoreTemplate.Helpers;
using RestSharpNetCoreTemplate.Requests;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace RestSharpNetCoreTemplate.Users
{
    [TestFixture]
    public class CreateUserTest : TestBase
    {
        public static IEnumerable CreateUser()
        {
            return GeneralHelpers.ReturnCSVData(GeneralHelpers.ReturnProjectPath() + "DataDriven/UsernameEmail.csv");
        }

        [Test, TestCaseSource("CreateUser")]
        [Parallelizable]
        public void CreateUserValido(ArrayList testData)
        {
            SolicitacaoDBSteps.DeleteUsuario();

            string username = "Jair_Melo10" + GeneralHelpers.ReturnGeneratesAutomaticString(1);
            string password = "p@ssw0rd";
            string real_name = "jair." + GeneralHelpers.ReturnGeneratesAutomaticString(2);
            string email = testData[0].ToString();
            string namelevel = "updater";

            CreateUserRequest createUserRequest = new CreateUserRequest();
            createUserRequest.SetJasoBody(username, password, real_name, email, namelevel);

            IRestResponse<dynamic> response = createUserRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.Created, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }

        [Test, TestCaseSource("CreateUser")]
        [Parallelizable]
        public void CreateUserInvalido(ArrayList testData)
        {
            string username = "Jair_Melo10";
            string password = "p@ssw0rd";
            string real_name = "jair test10";
            string email = testData[1].ToString();
            string namelevel = "updater";

            CreateUserRequest createUserRequest = new CreateUserRequest();
            createUserRequest.SetJasoBody(username, password, real_name, email, namelevel);

            IRestResponse<dynamic> response = createUserRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.BadRequest, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }

        [Test]
        [Parallelizable]
        public void CreateUserExisting()
        {
            string username = "Administrator";
            string password = "p@ssw0rd";
            string real_name = "Falho";
            string email = "teste@invalido.com";
            string namelevel = "updater";

            CreateUserRequest createUserRequest = new CreateUserRequest();
            createUserRequest.SetJasoBody(username, password, real_name, email, namelevel);

            IRestResponse<dynamic> response = createUserRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.BadRequest, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }
     }
 }