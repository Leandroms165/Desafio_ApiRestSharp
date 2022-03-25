using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issue
{
    public class CreateAnIssueNoteRequest : RequestBase
    {
        
        public  CreateAnIssueNoteRequest(string issue_id)
        {
            method = RestSharp.Method.POST;
            requestService = "/api/rest/issues/{issue_id}/notes";

            parameters.Add("issue_id", issue_id);
        }
        public void SetJsonBody(string text, string nameView_state)
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Issue/CreateAnIssueNote.json");
            jsonBody = jsonBody.Replace("$text", text);
            jsonBody = jsonBody.Replace("$nameView_state", nameView_state);
        }

    }
}
