using Microsoft.AspNetCore.Mvc;
using NFL.OData.Client.Mvc.Adapters;
using NFL.OData.Client.Mvc.Models;
using NFL.OData.Client.Mvc.Services;
using NFL.SqlServer.DataContext.Entities;
using System.Diagnostics;
using System.Text.Json;

namespace NFL.OData.Client.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public List<NFLPlay> NFLPlays { get; set; } = new();
        private readonly ILogger<HomeController> _logger;
        private IHttpClientFactory _clientFactory;
        private IODataAdapter _adapter;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory clientFactory, IODataAdapter adapter)
        {
            _logger = logger;
            _clientFactory = clientFactory;
            _adapter = adapter;
        }

        public async Task<IActionResult> Index()
        {
            JsonElement jsonElement = await _adapter.GetODataObject<NFLPlay>();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
