using PteroSharp.NET.Models;
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
            var request = new RestRequest($"/api/application/nests/{nestId}/eggs?include=nest,servers,variables,config");
            var response = await HandleRequestRawAsync<EggListResponse>(request, token);
            return response.Data;
        }

        //public async Task<EggListResponse> GetEggWithId(int nestId, int eggId, CancellationToken token = default)
        //{
        //    var eggs = await GetEggAsync(nestId, eggId, token);
        //    var egg = eggs.Data.FirstOrDefault(egg => egg.Attributes.Id == id);
        //    return 
        //}

        public async Task<EggData> GetEggWithIdAsync(int nestId, int eggId, CancellationToken token = default)
        {
            var request = new RestRequest($"/api/application/nests/{nestId}/eggs/{eggId}?include=nest,servers,variables,config");
            var response = await HandleRequestRawAsync<EggData>(request, token);
            return response.Data;
        }

        public async Task<ServerVariablesResponse> GetServerVariablesAsync(string serverId,
            CancellationToken token = default)
        {
            var request = new RestRequest($"/api/client/servers/{serverId}/startup");
            var response = await HandleRequestRawAsync<ServerVariablesResponse>(request, token);
            return response.Data;
        }

        public async Task<EggData> GetEggAsync(int nestId, int eggId, CancellationToken token = default)
        {
            var eggs = await GetEggsAsync(nestId, token);

            return eggs.Data.FirstOrDefault(egg => egg.Attributes.Id == eggId) ?? throw new Exception($"Egg with ID {eggId} not found in Nest {nestId}.");
        }

        public async Task<PterodactylList<AllocationAttributes>> GetFreeAllocationIDsAsync(int nodeId, CancellationToken token = default)
        {
            var request = new RestRequest($"/api/application/nodes/{nodeId}/allocations");
            var response = await HandleArrayRequest<BaseAttributes<AllocationAttributes>>(request, token);
            // Assuming you want to do something with the response
            // For now, just returning it
            var list = response.Select(rsp => rsp.Attributes);

            return new PterodactylList<AllocationAttributes>(list);
        }

        //public async Task<PterodactylList<EggListResponse>> GetEggsAsync(int NestId, CancellationToken token = default)
        //{
        //    var request = new RestRequest($"/api/application/nests/{NestId}/eggs");
        //    var response = await HandleArrayRequest<EggListResponse>(request, token);
        //    return response;
        //}


    }
}
