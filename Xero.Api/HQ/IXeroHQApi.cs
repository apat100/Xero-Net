using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xero.Api.HQ.Endpoints;
using Xero.Api.HQ.Model;

namespace Xero.Api.HQ
{
    public interface IXeroHQApi
    {
        //Clients
        IClientsEndpoint Clients { get; }

        //Alerts
        Alert Create(Alert item);
    }
}
