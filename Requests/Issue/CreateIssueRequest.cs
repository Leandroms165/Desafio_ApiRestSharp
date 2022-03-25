using RazorEngine;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using RestSharp;
using Encoding = System.Text.Encoding;

namespace RestSharpNetCoreTemplate.Requests
{
     public class CreateIssueRequest : RequestBase
    {
        public CreateIssueRequest()
        {
            method = Method.POST;
            requestService = "/api/rest/issues/";
            
        }
        public void SetJsonBody(string summary, string description, string name_project)
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Issue/CreateIssue.json", Encoding.UTF8);
            jsonBody = jsonBody.Replace("$summary", summary);
            jsonBody = jsonBody.Replace("$description", description);
            jsonBody = jsonBody.Replace("$name_project", name_project);

        }
    }
}
