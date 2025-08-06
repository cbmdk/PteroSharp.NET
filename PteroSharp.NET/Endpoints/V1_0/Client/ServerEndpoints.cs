
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PteroSharp.NET.Models;
using PteroSharp.NET.Objects.V1_0;
using PteroSharp.NET.Objects.V1_0.Client;
using PteroSharp.Objects.V1_0.Client;
using PteroSharp.Utils;
using RestSharp;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PteroSharp.Endpoints.V1_0.Client
{
    public class ServerEndpoints : BaseEndpoint
    {

        internal ServerEndpoints(IRestClient client) : base(client)
        { }

        public async Task<PterodactylList<ServerResponse>> GetServersAsync(CancellationToken token = default)
        {
            var request = new RestRequest("/api/client");

            var response = await HandleRequestRawAsync<ApiResponse<ServerResponse>>(request, token);

            //var list = response.Select(rsp => rsp.Attributes);
            var servers = response.Data.Data;

            return new PterodactylList<ServerResponse>(servers);
        }

        public async Task<ServerStatusResponse> GetServerStatus(string serverId, CancellationToken token = default)
        {
            var request = new RestRequest($"/api/client/servers/{serverId}");
            var response = await HandleRequestRawAsync<ServerStatusResponse>(request, token);
            return response.Data;
        }

        //public async Task<PterodactylList<Server>> GetServersAsync(Func<Server, bool> filter, CancellationToken token = default)
        //{
        //    var allServers = await GetServersAsync(token);
            
        //    var filtered = allServers.Where(filter);

        //    return new PterodactylList<Server>(filtered);
        //}

        public async Task GetServerVariables(string serverId, CancellationToken token = default)
        {

        }

        public async Task<BaseAttributes<CreateServerAttributes>> CreateMineCraftServer(CreateServerRequest serverRequest, CancellationToken token = default)
        {
            var allocation = await GetFreeAllocationIDAsync(4);

            serverRequest.Allocation = new AllocationConfig
            {
                Default = allocation.Attributes.Id,
            };
            var request = new RestRequest("/api/application/servers", Method.Post);

            // Configure JSON serialization to use snake_case
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                }
            };

            var json = JsonConvert.SerializeObject(serverRequest, settings);
            request.AddStringBody(json, DataFormat.Json);

            var response = await HandleRequestRawAsync<BaseAttributes<CreateServerAttributes>>(request, token);
            return response.Data;
        }

        public async Task<bool> CreateEulaFileOnServer(string serverId, CancellationToken token = default)
        {
            var request = new RestRequest($"/api/client/servers/{serverId}/files/write?file=%2Feula.txt", Method.Post);
            request.AddHeader("Content-Type", "text/plain");

            // Add the EULA content
            request.AddStringBody("eula=true", ContentType.Plain);

            try
            {
                var response = await HandleRequestRawAsync<BaseAttributes<CreateServerAttributes>>(request, token);
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
            return false;
        }

        public async Task<BaseAttributes<AllocationAttributes>> GetFreeAllocationIDAsync(int nodeId, CancellationToken token = default)
        {
            try
            {
                var request = new RestRequest($"/api/application/nodes/{nodeId}/allocations");
                var response = await HandleArrayRequest<BaseAttributes<AllocationAttributes>>(request, token);
                // Assuming you want to do something with the response
                // For now, just returning it
                var list = response.FirstOrDefault((x) => x.Attributes.Assigned == false);


                return list;

            }
            catch (Exception e)
            {

                throw;
            }
        }

        public async Task<CreateServerRequest> CreateServerAsync(CreateServerRequest server, CancellationToken token = default)
        {
            var serverData = new
            {
                name = "My New Server22222222222",
                user = 1,
                egg = 2,
                docker_image = "ghcr.io/pterodactyl/yolks:java_21",
                startup = "java -Xms128M -Xmx{{SERVER_MEMORY}}M -jar {{SERVER_JARFILE}}",
                environment = new
                {
                    VANILLA_VERSION = "latest",
                    SERVER_JARFILE = "server.jar"
                },
                limits = new
                {
                    memory = 3072,
                    swap = 0,
                    disk = 10000,
                    io = 500,
                    cpu = 100,
                    oom_disabled = false
                },
                feature_limits = new
                {
                    databases = 2,
                    allocations = 1,
                    backups = 5
                },
                allocation = new
                {
                    @default = 0
                }
            };
            var request = new RestRequest("/api/application/servers", Method.Post)
                .AddStringBody(JsonConvert.SerializeObject(serverData), DataFormat.Json);
            var rseponse = await HandleRequest<BaseAttributes<Server>>(request, token);

            return server;
        }

        public async Task<object> SendJsonAsync(string jsonString, CancellationToken token = default)
        {
            var request = new RestRequest("/api/application/servers", Method.Post)
                .AddStringBody(jsonString, DataFormat.Json);
            var response = await HandleRequestRawAsync<object>(request, token);
            return JsonConvert.DeserializeObject(response.Content);
        }



    }
}
