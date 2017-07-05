using Xero.Api.Common;
using Xero.Api.HQ.Endpoints;
using Xero.Api.HQ.Model;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.RateLimiter;

namespace Xero.Api.HQ
{
    public class XeroHQApi : XeroApi, IXeroHQApi
    {
        public XeroHQApi(string baseUri, IAuthenticator auth, IConsumer consumer, IUser user, IJsonObjectMapper readMapper, IXmlObjectMapper writeMapper)
            : this(baseUri, auth, consumer, user, readMapper, writeMapper, null)
        {
        }
        public XeroHQApi(string baseUri, IAuthenticator auth, IConsumer consumer, IUser user, IJsonObjectMapper readMapper, IXmlObjectMapper writeMapper, IRateLimiter rateLimiter) 
            : base(baseUri, auth, consumer, user, readMapper, writeMapper, rateLimiter)
        {
            Connect();
        }

        public IClientsEndpoint Clients { get; private set; }
        public IAlertsEndpoint Alerts { get; private set; }

        private void Connect()
        {
            Clients = new ClientsEndpoint(Client);
            Alerts = new AlertsEndpoint(Client);
        }

        #region Alerts

        public Alert Create(Alert item)
        {
            return Alerts.Create(item);
        }

        #endregion
    }
}
