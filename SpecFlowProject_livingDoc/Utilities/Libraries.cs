using Newtonsoft.Json.Linq;
using RestSharp;
using System.Threading.Tasks;

namespace SpecFlowProject_livingDoc.Utilities
{
    public static class Libraries
    {
        public static string GetResponseObject(this IRestResponse response, string responseObject)
        {
            JObject obs = JObject.Parse(response.Content);
            return obs[responseObject].ToString();
        }

        public static async Task<IRestResponse> ExecuteAsyncRequests<T>(this RestClient client, IRestRequest request) where T : class, new()
        {
            return await client.ExecuteAsync(request);
        }

    }
}
