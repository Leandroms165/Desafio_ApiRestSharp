using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Projects
{
    public class GetAllProjectsRequest: RequestBase
    {
        public GetAllProjectsRequest()
        {
            method = RestSharp.Method.GET;
            requestService = "/api/rest/projects";
        }
    }
}
