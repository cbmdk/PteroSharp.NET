using PteroSharp.NET.Models;
using PteroSharp.Objects.V0_7.Admin;
using PteroSharp.Objects.V1_0.Client;
using PteroSharp.Utils;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PteroSharp.NET.Objects.V1_0.Client;

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

        public async Task<NestListResponse> GetNestsAsync(CancellationToken token = default)
        {
            var request = new RestRequest("/api/application/nests");
            var response = await HandleRequestRawAsync<NestListResponse>(request, token);
            
            
            return response.Data;
        }

        public async Task<NestData> GetNestAsync(int nestId, CancellationToken token = default)
        {
            var request = new RestRequest($"/api/application/nests/{nestId}");
            var response = await HandleRequestRawAsync<NestData>(request, token);
            return response.Data;
        }

        public async Task<EggListResponse> GetEggsAsync(int nestId, CancellationToken token = default)
        {
            var request = new RestRequest($"/api/application/nests/{nestId}/eggs?include=nest,servers");
            var response = await HandleRequestRawAsync<EggListResponse>(request, token);
            return response.Data;
        }

        //public async Task<EggData> GetEggAsync(int nestId, CancellationToken token = default)
        //{

        //}

        //public async Task<PterodactylList<EggListResponse>> GetEggsAsync(int NestId, CancellationToken token = default)
        //{
        //    var request = new RestRequest($"/api/application/nests/{NestId}/eggs");
        //    var response = await HandleArrayRequest<EggListResponse>(request, token);
        //    return response;
        //}


    }
}
