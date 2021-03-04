using System;
using System.Text.Json.Serialization;

namespace GreetingClient.Proxies
{
    public class Greeting
    {
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

    }
}
