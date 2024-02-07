using Nfl.SqlServer.DataContext.Entities;
using Radzen;

namespace Nfl.BlazorWasm
{
    public partial class NflODataService
    {
        private readonly HttpClient _httpClient;
        private readonly Uri baseUri;
        public NflODataService(string url = "")
        {
            this._httpClient = new HttpClient();
            this.baseUri = new Uri(url);
        }
        partial void OnGetNflPlays(HttpRequestMessage requestMessage);

        public async Task<ODataServiceResult<NflPlay>> GetNflPlays(string filter = default(string), int? top = default(int?),
            int? skip = default(int?), string orderby = default(string), string expand = default(string),
            string select = default(string), bool? count = default(bool?))
        {
            var uri = new Uri(baseUri, "NflPlays");
            uri = uri.GetODataUri(filter: filter, top: top, skip: skip, orderby: orderby, expand: expand,
                select: select, count: count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetNflPlays(httpRequestMessage);

            var response = await _httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<NflPlay>>();
        }
    }
}
