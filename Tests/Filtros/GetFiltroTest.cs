using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests.Filtros;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Filters
{
    public class GetFiltroTest : TestBase
    {
        [Test]
        public void GetFiltroValido()
        {
            string filtro_id = "3";

            GetFiltroRequest getFiltroRequest = new GetFiltroRequest(filtro_id);
            IRestResponse<dynamic> response = getFiltroRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);

        }
    }
}
