using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issue_Request
{
    public class DeleteIssueRequest : RequestBase
    {
        public DeleteIssueRequest(string id_delete)
        {
            method = RestSharp.Method.DELETE;
            requestService = "/api/rest/issues/{id_delete}";

            parameters.Add("id_delete", id_delete);
        }

    }
}
