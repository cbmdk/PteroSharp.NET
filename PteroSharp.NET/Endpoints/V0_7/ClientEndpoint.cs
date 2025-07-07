using PteroSharp.Endpoints.V0_7.Client;
using RestSharp;

namespace PteroSharp.Endpoints.V0_7
{
    public class ClientEndpoint
    {

        public ServerEndpoints Servers { get; }

        public ClientEndpoint(IRestClient client)
        {
            Servers = new ServerEndpoints(client);
        }


    }
}
