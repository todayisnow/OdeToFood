using Microsoft.Extensions.Configuration;

namespace OdeToFood.Services
{
    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }
    public class Greeter : IGreeter
    {
        private string _message;

        public Greeter(IConfiguration config)
        {
            _message = config["Greeting"];
        }
        public string GetMessageOfTheDay()
        {
            return _message;
        }
    }
}