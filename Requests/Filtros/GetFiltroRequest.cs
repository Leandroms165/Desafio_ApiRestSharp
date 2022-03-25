using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Filtros
{
    public class GetFiltroRequest : RequestBase
    {
        public GetFiltroRequest(string filtro_id)
        {
            method = RestSharp.Method.GET;
            requestService = "/api/rest/filters/{filtro_id}";

            parameters.Add("filtro_id", filtro_id);
        }
    }
}
