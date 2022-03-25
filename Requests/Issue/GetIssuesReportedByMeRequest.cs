using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issue
{
    public class GetIssuesReportedByMeRequest : RequestBase
    {
        public GetIssuesReportedByMeRequest(string id_filter)
        {
            method = RestSharp.Method.GET;
            requestService = "api/rest/issues?filter_id{id_filter}";

            parameters.Add("id_filter", id_filter);

        }
    }
}
