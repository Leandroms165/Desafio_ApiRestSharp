using System;
using System.Collections.Generic;
using System.Text;
using RestSharpNetCoreTemplate.Bases;


namespace RestSharpNetCoreTemplate.Requests
{
    public  class GetIssueRequest : RequestBase
    {
        public GetIssueRequest (string id_issue)
        {
            method = RestSharp.Method.GET;
            requestService = "/api/rest/issues/{Id_issue}";

            parameters.Add("Id_issue", id_issue);

        }
        
    }
}
