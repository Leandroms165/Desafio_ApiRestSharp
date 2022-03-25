using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issue
{
    public class GetUnassignedIssuesRequest: RequestBase
    {
        public  GetUnassignedIssuesRequest(string filter_id)
        {
            method = RestSharp.Method.GET;
            requestService = "api/rest/issues?filter_id{filter_id}";

            parameters.Add("filter_id", filter_id);
        }
    }
}
