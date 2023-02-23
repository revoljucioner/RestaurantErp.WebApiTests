using System.Configuration;

namespace RestaurantErp.WebApiTests.Providers
{
    public class BaseProvider
    {
        protected string BaseUrl = ConfigurationManager.AppSettings["BaseUrl"];
        protected HttpClient HttpClient = new HttpClient();
    }
}
