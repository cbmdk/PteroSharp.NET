using PteroSharp.Objects.V1_0.Client;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PteroSharp.NET.Models;

namespace PteroSharp.Endpoints.V1_0.Client
{
    public class ApplicationEndpoints : BaseEndpoint
    {
        public ApplicationEndpoints(IRestClient client) : base(client)
        {
        }

        public async Task<Account> GetUserAsync(int UserId, CancellationToken token = default)
        {
            var request = new RestRequest($"/api/application/users/{UserId}");
            var response = await HandleRequest<Account>(request, token);
            return response;
        }

        public async Task<NestListResponse> GetNests(CancellationToken token = default)
        {
            var request = new RestRequest("/api/application/ntests");
            var response = await HandleRequest<NestListResponse>(request, token);
            return response;
        }


    }
}
