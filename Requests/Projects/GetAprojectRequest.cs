using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Projects
{
    public class GetAprojectRequest: RequestBase
    {
        public GetAprojectRequest(string id_project) 
        {
            method = RestSharp.Method.GET;
            requestService = "/api/rest/projects/{id_project}";

            parameters.Add("id_project", id_project);
        }
    }
}
