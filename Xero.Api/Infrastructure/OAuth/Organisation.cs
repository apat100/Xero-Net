using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Infrastructure.OAuth
{
    public class Organisation : ITenant
    {
        public Organisation() { }

        public string Query
        {
            get { return null; }
        }
    }
}
