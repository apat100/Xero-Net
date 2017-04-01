﻿using System.Collections.Generic;
using System.Linq;
using System.Net;
using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Model;
using Xero.Api.Core.Request;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Exceptions;
using Xero.Api.Infrastructure.Http;
using Xero.Api.Infrastructure.Model;

namespace Xero.Api.Core.Endpoints
{
    public interface IAlertsEndpoint
    {
        Alert Create(Alert alert);
    }

    public class AlertsEndpoint : IAlertsEndpoint
    {
        public XeroHttpClient Client { get; private set; }

        internal AlertsEndpoint(XeroHttpClient client)
        {
            Client = client;
        }

        public Alert Create(Alert alert)
        {
            var endpoint = "xero.hq/1.0/alerts";
            var resp = Client.Client.Post(endpoint, Client.JsonMapper.To(alert), "application/json");
            return HandleAlertResponse(resp);
        }

        private Alert HandleAlertResponse(Infrastructure.Http.Response response)
        {
            if (response.StatusCode == HttpStatusCode.OK
                || response.StatusCode == HttpStatusCode.Created
                || response.StatusCode == HttpStatusCode.Accepted)
            {
                return Client.JsonMapper.From<Alert>(response.Body);
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