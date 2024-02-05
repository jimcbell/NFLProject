using Microsoft.AspNetCore.Mvc;
using Nfl.SqlServer.DataContext.Entities;
using NFL.OData.Client.Mvc.Adapters;
using NFL.OData.Client.Mvc.Models;
using System.Diagnostics;
using System.Text.Json;

namespace NFL.OData.Client.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public List<NflPlay> NFLPlays { get; set; } = [];
        public HomeIndexViewModel ViewModel { get; set; } = new();
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
            //HomeIndexViewModel viewModel = new HomeIndexViewModel();
            ViewModel.NFLPlays = await _adapter.GetODataObject<NflPlay>();

            return View(ViewModel);
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
