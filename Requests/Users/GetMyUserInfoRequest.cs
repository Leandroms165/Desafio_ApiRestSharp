using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Users
{
    public class GetMyUserInfoRequest: RequestBase
    {
        public GetMyUserInfoRequest()
        {
            method = RestSharp.Method.GET;
            requestService = "/api/rest/users/me";
        }
    }
}
