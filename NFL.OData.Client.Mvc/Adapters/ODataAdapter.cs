using System.Text.Json;

namespace NFL.OData.Client.Mvc.Adapters
{
    public interface IODataAdapter
    {
        Task<JsonElement> GetODataObject<T>();
    }
    public class ODataAdapter : IODataAdapter
    {
        private IHttpClientFactory _clientFactory;

        public ODataAdapter(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<JsonElement> GetODataObject<T>()
        {
            HttpClient client = _clientFactory.CreateClient("NFLPlay");
            HttpRequestMessage request = new HttpRequestMessage();
            request.Method = HttpMethod.Get;
            HttpResponseMessage response = await client.SendAsync(request);
            JsonElement jsonElement = await response.Content.ReadFromJsonAsync<JsonElement>();
            return jsonElement!;
        }
    }
}
