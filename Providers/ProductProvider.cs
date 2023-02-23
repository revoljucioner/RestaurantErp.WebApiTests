using Newtonsoft.Json;
using RestaurantErp.Core.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantErp.WebApiTests.Providers
{
    public class ProductProvider
    {
        private string _baseUrl = "https://restauranterp.azurewebsites.net/";
        private HttpClient _httpClient = new HttpClient();

        //public ProductProvider(HttpClient httpClient)
        //{
        //    _httpClient = httpClient;
        //}

        public async Task<Guid> AddProduct(AddProductRequest productInfo)
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_baseUrl}/Admin/CreateProduct"),
                Content = new StringContent(JsonConvert.SerializeObject(productInfo), Encoding.UTF8, "application/json")
            };

            HttpResponseMessage response = await _httpClient.SendAsync(request);

            return JsonConvert.DeserializeObject<Guid>(await response.Content.ReadAsStringAsync());
        }
    }
}
