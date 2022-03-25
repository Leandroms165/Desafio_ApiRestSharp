using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issue
{
    public class GetAllIssuesRequest : RequestBase
    {
        public GetAllIssuesRequest(string page_size, string page)
        {
            method = RestSharp.Method.GET;
            requestService = "api/rest/issues?page_size={page_size}&page={page}";

            parameters.Add("page_size", page_size);
            parameters.Add("page", page);
        }
    }
}
