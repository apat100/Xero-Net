using System.Collections.Generic;
using Xero.Api.Common;
using Xero.Api.Core.Model;

namespace Xero.Api.HQ.Response
{
    public class ClientsResponse
    {
        public List<Model.Client> Items { get; set; }
    }
}