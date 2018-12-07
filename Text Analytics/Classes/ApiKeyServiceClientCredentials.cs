using Microsoft.Rest;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Text_Analytics
{
    /// <summary>
    /// This class is the container for the API subscription credentials
    /// </summary>
    class ApiKeyServiceClientCredentials : ServiceClientCredentials
    {
        /// <summary>
        /// Container for subscription credentials. Make sure to enter your valid key.
        /// Copyright: https://docs.microsoft.com/en-us/azure/cognitive-services/text-analytics/quickstarts/csharp
        /// </summary>
        
        // Add subscription key here
        string[] subscriptionKeys = { "" };

        /// <summary>
        /// Subscription container
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override Task ProcessHttpRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("Ocp-Apim-Subscription-Key", subscriptionKeys[0]);
            return base.ProcessHttpRequestAsync(request, cancellationToken);
        }
    }
}
