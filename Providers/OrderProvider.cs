using Newtonsoft.Json;
using RestaurantErp.Core.Models.Bill;
using RestaurantErp.Core.Models.Order;
using System.Text;

namespace RestaurantErp.WebApiTests.Providers
{
    public class OrderProvider
    {
        private string _baseUrl = "https://restauranterp.azurewebsites.net/";

        private HttpClient _httpClient = new HttpClient();

        //public OrderProvider(HttpClient httpClient)
        //{
        //    _httpClient = httpClient;
        //}

        public async Task<Guid> Create()
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_baseUrl}/Order/CreateOrder")
            };

            HttpResponseMessage response = await _httpClient.SendAsync(request);

            return JsonConvert.DeserializeObject<Guid>(await response.Content.ReadAsStringAsync());
        }

        public async Task AddItem(OrderItemRequest orderItemRequest)
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_baseUrl}/Order/AddItem"),
                Content = new StringContent(JsonConvert.SerializeObject(orderItemRequest), Encoding.UTF8, "application/json")
            };
            
            await _httpClient.SendAsync(request);
        }

        public async Task Cancel(OrderItemRequest orderItemRequest)
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri($"{_baseUrl}/Order/CancelItem"),
                Content = new StringContent(JsonConvert.SerializeObject(orderItemRequest), Encoding.UTF8, "application/json")
            };

            await _httpClient.SendAsync(request);
        }

        public async Task<BillExternal> Checkout(Guid id)
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_baseUrl}/Order/Checkout?orderId={id}")
            };

            HttpResponseMessage response = await _httpClient.SendAsync(request);

            return JsonConvert.DeserializeObject<BillExternal>(await response.Content.ReadAsStringAsync());
        }
    }
}
