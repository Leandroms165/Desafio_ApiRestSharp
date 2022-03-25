using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issue
{
    public  class DeleteAnIssueNoteRequest : RequestBase
    {
        public DeleteAnIssueNoteRequest(string issue_id, string issue_note_id)
        {
            method = RestSharp.Method.DELETE;
            requestService = "api/rest/issues/{issue_id}/notes/{issue_note_id}";

            parameters.Add("issue_id", issue_id);
            parameters.Add("issue_note_id", issue_note_id);
        }
    }
}
