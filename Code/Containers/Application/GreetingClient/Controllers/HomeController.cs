using GreetingClient.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using GreetingClient.Configuration;
using Microsoft.Extensions.Options;
using GreetingClient.Proxies;

namespace GreetingClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGreetingProxy _greetingProxy;

        public HomeController(ILogger<HomeController> logger, IGreetingProxy greetingProxy)
        {
            _logger = logger;
            _greetingProxy = greetingProxy;
        }

        public async System.Threading.Tasks.Task<IActionResult> IndexAsync()
        {
            _logger.LogInformation("Default request started...");

            ViewData["ClientMessage"] = $"Client '{Dns.GetHostName()}' ({GetLocalIPAddress()}) says: Hello server, how are you?";

            var answer = await _greetingProxy.SayHello();
            ViewData["ServerMessage"] = $"Server answers: {answer.Message}";

            _logger.LogInformation("Default request done.");

            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Message"] = "LIBA's Hello World.";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public static IPAddress GetLocalIPAddress()
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                return null;
            }
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            return host
                .AddressList
                .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
        }
    }
}
