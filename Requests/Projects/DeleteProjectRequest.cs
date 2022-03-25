using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Projects
{
    public class DeleteProjectRequest : RequestBase
    {
        public DeleteProjectRequest(string project_id)
        {
            method = RestSharp.Method.DELETE;
            requestService = "/api/rest/projects/{project_id}";

            parameters.Add ("project_id", project_id);
        }
    }
}
