using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RestSharpNetCoreTemplate.Projects
{
    public class CreateaProjectVersionRequest : RequestBase
    {
        public CreateaProjectVersionRequest (string project_id)
        {
            method = RestSharp.Method.POST;
            requestService = "/api/rest/projects/{project_id}/versions/";

            parameters.Add("project_id", project_id);
        }

        public void SetJsonBody(string nameVersion)
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Project/CreateaProjectVersion.json");
            jsonBody = jsonBody.Replace("$name", nameVersion);
        }
    }
}
