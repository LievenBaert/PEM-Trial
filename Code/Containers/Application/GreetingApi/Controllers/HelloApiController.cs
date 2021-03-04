using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace GreetingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloApiController : ControllerBase
    {
        private static readonly string[] feelings = new[]
        {
            "freezing", "bracing", "chilly", "cool", "mild", "warm", "balmy", "hot", "sweltering", "scorching"
        };

        private readonly ILogger<HelloApiController> _logger;
        public HelloApiController(ILogger<HelloApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult SayHello()
        {
            _logger.LogInformation($"Say Hello...");

            var rng = new Random();

            var temperatureC = rng.Next(-20, 55);
            var feeling = feelings[rng.Next(feelings.Length)];

            return Ok(new Greeting
            {
                Date = DateTime.Now,
                Message = $"Eh well, it's {feeling} here on the server '{Dns.GetHostName()}' ({GetLocalIPAddress()}). It's {temperatureC} degrees!"
            });
        }

        private static IPAddress GetLocalIPAddress()
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
