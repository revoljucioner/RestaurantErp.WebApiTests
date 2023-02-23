using RestaurantErp.Core.Models.Product;
using RestaurantErp.WebApiTests.Extensions;
using RestaurantErp.WebApiTests.Providers;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace RestaurantErp.WebApiTests.StepDefinitions
{
    [Binding]
    public class ProductSteps
    {
        private readonly DataContext _context;
        private readonly ProductProvider _productProvider;

        public ProductSteps(DataContext context,
            ProductProvider productProvider)
        {
            _context = context;
            _productProvider = productProvider;
        }

        [Given(@"Create products? as follow")]
        public async Task GivenCreateProductsAsFollow(Table table)
        {
            var ds = table.CreateSet<CreateProductDataSource>();

            var taskByIndex = await ds.ToDictionary(i => i.Index, i => _productProvider.AddProduct(new AddProductRequest
            {
                Name = i.Name,
                Price = i.Price
            }))
            .ToResults();

            foreach(var pair in taskByIndex)
            {
                _context.AddProduct(pair.Key, pair.Value);
            }
        }
    }

    public class CreateProductDataSource
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}