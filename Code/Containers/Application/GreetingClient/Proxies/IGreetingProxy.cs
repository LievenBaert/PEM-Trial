using System.Threading.Tasks;

namespace GreetingClient.Proxies
{
    public interface IGreetingProxy
    {
        public Task<Greeting> SayHello();
    }
}
