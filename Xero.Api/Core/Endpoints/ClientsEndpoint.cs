using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Xero.Api.Common;
using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Model;
using Xero.Api.Core.Request;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Exceptions;
using Xero.Api.Infrastructure.Http;
using Xero.Api.Infrastructure.Model;

namespace Xero.Api.Core.Endpoints
{
    public interface IClientsEndpoint
    {
        IEnumerable<Client> Find();
    }

    public class ClientsEndpoint : IClientsEndpoint
    {
        public XeroHttpClient Client { get; private set; }
        internal ClientsEndpoint(XeroHttpClient client)
        {
            Client = client;
        }

        public IEnumerable<Client> Find()
        {
            var endpoint = "/xero.hq/1.0/clients";

            var clients = HandleClientsResponse(Client
                .Client
                .Get(endpoint, ""));

            return clients;
        }

        private IEnumerable<Client> HandleClientsResponse(Infrastructure.Http.Response response)
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var json = response.Body;

                var result = Client.JsonMapper.From<ClientsResponse>(json);

                return result.Items;
            }

            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                var data = Client.JsonMapper.From<List<ValidationError>>(response.Body);

                if (data.Any())
                {
                    throw new XeroHqApiException(data);
                }

                return null;
            }

            Client.HandleErrors(response);

            return null;
        }
    }
}