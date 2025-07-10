
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using PteroSharp.NET.Objects.V1_0.Client;
using PteroSharp.Objects.V1_0.Client;
using PteroSharp.Utils;
using RestSharp;

namespace PteroSharp.Endpoints.V1_0.Client
{
    public class ServerEndpoints : BaseEndpoint
    {

        internal ServerEndpoints(IRestClient client) : base(client)
        { }

        public async Task<PterodactylList<Server>> GetServersAsync(CancellationToken token = default)
        {
            var request = new RestRequest("/api/client");

            var response = await HandleArrayRequest<BaseAttributes<Server>>(request, token);

            var list = response.Select(rsp => rsp.Attributes);

            return new PterodactylList<Server>(list);
        }

        public async Task<PterodactylList<Server>> GetServersAsync(Func<Server, bool> filter, CancellationToken token = default)
        {
            var allServers = await GetServersAsync(token);
            
            var filtered = allServers.Where(filter);

            return new PterodactylList<Server>(filtered);
        }

        public async Task GetServerVariables(string serverId, CancellationToken token = default)
        {

        }

        public async Task<CreateServerRequest> CreateServerAsync(CreateServerRequest server, CancellationToken token = default)
        {
            var request = new RestRequest("/api/application/servers", Method.Post)
                .AddJsonBody(server);
            var rseponse = await HandleRequest<BaseAttributes<Server>>(request, token);

            return server;
        }




    }
}
