using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issue
{
    public class GetIssuesMonitoredByMeRequest : RequestBase
    {
        public GetIssuesMonitoredByMeRequest (string filter_id)
        {
            method = RestSharp.Method.GET;
            requestService = "/api/rest/issues";

            parameters.Add("filter_id", filter_id);
        }
    }
}
