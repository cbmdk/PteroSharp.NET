using PteroSharp.Endpoints.V1_0.Client;
using RestSharp;

namespace PteroSharp.Endpoints.V1_0
{
    public class ClientEndpoint
    {

        public ServerEndpoints Servers { get; }

        public AccountEndpoints Account { get; }

        public ApplicationEndpoints Application { get; }

        public ClientEndpoint(IRestClient client)
        {
            Servers = new ServerEndpoints(client);
            Account = new AccountEndpoints(client);
            Application = new ApplicationEndpoints(client);
        }

    }
}
