using RestaurantErp.Core.Models.Discount;
using System.Text;
using System.Text.Json;

namespace RestaurantErp.WebApiTests.Providers
{
    public class DiscountProvider: BaseProvider
    {
        public async Task Add(DiscountByTimeSettings discountByTimeSettings)
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{BaseUrl}/Admin/AddDiscountByTimeSettings"),
                Content = new StringContent(JsonSerializer.Serialize(discountByTimeSettings), Encoding.UTF8, "application/json")
            };

            await HttpClient.SendAsync(request);
        }
    }
}
