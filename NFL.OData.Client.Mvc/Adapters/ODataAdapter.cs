using Nfl.SqlServer.DataContext.Entities;
using OData.Json.Helper;
using System.Text.Json;

namespace NFL.OData.Client.Mvc.Adapters
{
    public interface IODataAdapter
    {
        Task<List<NflPlay>> GetODataObject<T>();
    }
    public class ODataAdapter : IODataAdapter
    {
        private IHttpClientFactory _clientFactory;

        public ODataAdapter(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<List<NflPlay>> GetODataObject<T>()
        {
            HttpClient client = _clientFactory.CreateClient("ODataServer");
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "nflplays/NFLPlay");
            HttpResponseMessage response = await client.SendAsync(request);
            List<NflPlay> nflPlays = await response.ParseContent<List<NflPlay>>() ?? new();
            string text = await response.Content.ReadAsStringAsync();
            return nflPlays;
        }
    }
}
