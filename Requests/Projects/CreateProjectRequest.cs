using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Projects
{
    public class CreateProjectRequest : RequestBase
    {
        public CreateProjectRequest()
        {
            method = RestSharp.Method.POST;
            requestService = "/api/rest/projects/";
        }

        public void SetJasoBody(string name, string nameStatus, string labelStatus, string description,
            string file_path, string nameView_state, string labelView_state )
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Project/CreateProject.json");
            jsonBody = jsonBody.Replace("$name", name);
            jsonBody = jsonBody.Replace("$nameStatus", nameStatus);
            jsonBody = jsonBody.Replace("$labelStatus", labelStatus);
            jsonBody = jsonBody.Replace("$description", description);
            jsonBody = jsonBody.Replace("$file_path", file_path);
            jsonBody = jsonBody.Replace("$nameView_state", nameView_state);
            jsonBody = jsonBody.Replace("$labelView_state", labelView_state);
        }
    }
}
