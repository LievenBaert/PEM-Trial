using GreetingClient.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace GreetingClient.Proxies
{
    public class HelloApiProxy: System.IDisposable, IGreetingProxy
    {
        private readonly HttpClient _client;

        private readonly ILogger _logger;
        private readonly IOptions<ApiConfiguration> _configuration;

        public HelloApiProxy(ILogger<HelloApiProxy> logger, IOptions<ApiConfiguration> apiConfig)
        {
            _logger = logger;
            _configuration = apiConfig;

            _client = new HttpClient();
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<Greeting> SayHello()
        {
            var greetingUrl = $"{_configuration.Value.ApiUrlGreeting}/HelloApi";
            _logger.LogInformation($"Calling {greetingUrl}...");

            var streamTask = _client.GetStreamAsync(greetingUrl);
            return await JsonSerializer.DeserializeAsync<Greeting>(await streamTask);
        }
    }
}
