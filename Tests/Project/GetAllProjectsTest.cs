using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests.Projects;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Project
{
    public class GetAllProjectsTest: TestBase
    {
        [Test]
        public void GetAllProjects()
        {
            GetAllProjectsRequest getAllProjectsRequest = new GetAllProjectsRequest();
            IRestResponse<dynamic> response = getAllProjectsRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);
        }
    }
}
