using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Infrastructure.OAuth
{
    public class Consumer : IConsumer
    {
        // For serialization
        public Consumer()
        {
        }

        public Consumer(string consumerKey, string consumerSecret) :
            this(consumerKey, consumerSecret, new Organisation()) //default to Organisation tenant
        {
        }

        public Consumer(string consumerKey, string consumerSecret, ITenant tenant)
        {
            ConsumerKey = consumerKey;
            ConsumerSecret = consumerSecret;
            Tenant = tenant;
        }

        public string ConsumerKey { get; internal set; }
        public string ConsumerSecret { get; internal set; }
        public ITenant Tenant { get; internal set; }
    }
}
