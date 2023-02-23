using RestaurantErp.Core.Models.Discount;
using System.Text;
using System.Text.Json;

namespace RestaurantErp.WebApiTests.Providers
{
    public class DiscountProvider
    {
        private string _baseUrl = "https://restauranterp.azurewebsites.net/";
        private HttpClient _httpClient = new HttpClient();

        //public DiscountProvider(HttpClient httpClient)
        //{
        //    _httpClient = new HttpClient();
        //}

        public async Task Add(DiscountByTimeSettings discountByTimeSettings)
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_baseUrl}/Admin/AddDiscountByTimeSettings"),
                Content = new StringContent(JsonSerializer.Serialize(discountByTimeSettings), Encoding.UTF8, "application/json")
            };

            await _httpClient.SendAsync(request);
        }
    }
}
