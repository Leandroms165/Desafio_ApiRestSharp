using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Users
{
    public class DeleteaUserRequest : RequestBase
    {
        public DeleteaUserRequest(string id_user)
        {
            method = RestSharp.Method.DELETE;
            requestService = "/api/rest/users/{id_user}";

            parameters.Add("id_user", id_user);
        }
    }
}
