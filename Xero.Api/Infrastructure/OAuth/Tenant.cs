using Xero.Api.Common;
using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Infrastructure.OAuth
{
    public class Tenant : ITenant
    {
        private const string Name = "tenantType";
        private string Type;

        public Tenant(string type)
        {
            Type = type;
        }

        public string Query
        {
            get
            {
                return $"{Name}={Type}";
            }
        }
    }
}
