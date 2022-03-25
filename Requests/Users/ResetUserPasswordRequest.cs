using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Users
{
    public class ResetUserPasswordRequest : RequestBase
    {
        public ResetUserPasswordRequest(string user_id)
        {
            method = RestSharp.Method.PUT;
            requestService = "/api/rest/users/{user_id}/reset";

            parameters.Add("user_id", user_id);
        }
    }
}
