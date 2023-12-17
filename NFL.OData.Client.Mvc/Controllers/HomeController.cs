using Microsoft.AspNetCore.Mvc;
using NFL.OData.Client.Mvc.Models;
using NFL.OData.Client.Mvc.Services;
using NFL.SqlServer.DataContext.Entities;
using System.Diagnostics;

namespace NFL.OData.Client.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public List<NFLPlay> NFLPlays { get; set; } = new();
        private readonly ILogger<HomeController> _logger;
        private IHttpClientFactory _clientFactory;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory clientFactory)
        {
            _logger = logger;
            _clientFactory = clientFactory;
        }

        public IActionResult Index()
        {
            Uri uri = new Uri("https://localhost:5134");
            NFLPlayContainer container = new NFLPlayContainer(uri);
            var query = container.NFLPlays.;
            foreach(var play in query)
            {
                NFLPlays.Add(play);
            }   
            HttpClient httpClient = _clientFactory.CreateClient("NFLPlay");
            var response = httpClient.GetAsync("NFLPlay").Result;
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
