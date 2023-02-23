using Newtonsoft.Json;
using RestaurantErp.Core.Models.Bill;
using RestaurantErp.Core.Models.Order;
using System.Text;

namespace RestaurantErp.WebApiTests.Providers
{
    public class OrderProvider: BaseProvider
    {
        public async Task<Guid> Create()
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{BaseUrl}/Order/CreateOrder")
            };

            HttpResponseMessage response = await HttpClient.SendAsync(request);

            return JsonConvert.DeserializeObject<Guid>(await response.Content.ReadAsStringAsync());
        }

        public async Task AddItem(OrderItemRequest orderItemRequest)
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{BaseUrl}/Order/AddItem"),
                Content = new StringContent(JsonConvert.SerializeObject(orderItemRequest), Encoding.UTF8, "application/json")
            };
            
            await HttpClient.SendAsync(request);
        }

        public async Task Cancel(OrderItemRequest orderItemRequest)
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri($"{BaseUrl}/Order/CancelItem"),
                Content = new StringContent(JsonConvert.SerializeObject(orderItemRequest), Encoding.UTF8, "application/json")
            };

            await HttpClient.SendAsync(request);
        }

        public async Task<BillExternal> Checkout(Guid id)
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{BaseUrl}/Order/Checkout?orderId={id}")
            };

            HttpResponseMessage response = await HttpClient.SendAsync(request);

            return JsonConvert.DeserializeObject<BillExternal>(await response.Content.ReadAsStringAsync());
        }
    }
}
