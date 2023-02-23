using Newtonsoft.Json;
using RestaurantErp.Core.Models.Product;
using System.Text;

namespace RestaurantErp.WebApiTests.Providers
{
    public class ProductProvider: BaseProvider
    {
        public async Task<Guid> AddProduct(AddProductRequest productInfo)
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{BaseUrl}/Admin/CreateProduct"),
                Content = new StringContent(JsonConvert.SerializeObject(productInfo), Encoding.UTF8, "application/json")
            };

            HttpResponseMessage response = await HttpClient.SendAsync(request);

            return JsonConvert.DeserializeObject<Guid>(await response.Content.ReadAsStringAsync());
        }
    }
}
