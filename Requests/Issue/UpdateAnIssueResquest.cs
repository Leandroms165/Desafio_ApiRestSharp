using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issue_Request
{
    public class UpdateAnIssueResquest : RequestBase
    {
        public UpdateAnIssueResquest (string issue_id)
        {
            method = RestSharp.Method.PATCH;
            requestService = "api/rest/issues/{issue_id}";

            parameters.Add("issue_id", issue_id.ToString());
        }

        public void SetJsonBody(string summary, string description)
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Issue/UpdateAnIssue.json", Encoding.UTF8);
            jsonBody = jsonBody.Replace("$summary", summary);
            jsonBody = jsonBody.Replace("$description", description);
        }
    }
}
