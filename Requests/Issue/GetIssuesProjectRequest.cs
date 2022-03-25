using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issue
{
    public class GetIssuesProjectRequest: RequestBase
    {
        public GetIssuesProjectRequest(string id_project)
        {
            method = RestSharp.Method.GET;
            requestService = "api/rest/issues?project_id={Id_project}";

            parameters.Add("Id_project", id_project);
        }
    }
}
