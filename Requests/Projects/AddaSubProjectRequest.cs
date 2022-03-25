using RazorEngine;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Projects
{
     public class AddaSubProjectRequest: RequestBase
    {
        public  AddaSubProjectRequest(string project_id)
        {
            method = RestSharp.Method.POST;
            requestService = "/api/rest/projects/{project_id}/subprojects";

            parameters.Add("project_id", project_id);
        }

        public void SetJsonBody(string name)
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Project/AddaSubProject.json");
            jsonBody = jsonBody.Replace("$Name", name);
        }
    }
}
