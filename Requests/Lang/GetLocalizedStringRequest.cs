using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Lang
{
    public class GetLocalizedStringRequest : RequestBase
    {
        public GetLocalizedStringRequest(string desc)
        {
            method = RestSharp.Method.GET;
            requestService = "/api/rest/lang?string={desc}";

            parameters.Add("desc", desc);
        }
    }
}
