using RestaurantErp.Core.Models.Order;
using RestaurantErp.WebApiTests.Providers;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace RestaurantErp.WebApiTests.StepDefinitions
{
    [Binding]
    public class OrderSteps
    {
        private readonly DataContext _context;
        private readonly OrderProvider _provider;

        public OrderSteps(DataContext context,
            OrderProvider provider)
        {
            _context = context;
            _provider = provider;
        }

        [When(@"Create order")]
        public async Task WhenCreateOrderWithIndex()
        {
            _context.OrderId = await _provider.Create();
        }

        [When(@"Add items to order as follow")]
        public async Task WhenAddItemsToOrderAsFollow(Table table)
        {
            var dsc = table.CreateSet<AddOrderItemDataSource>();

            foreach (var ds in dsc)
            {
                var request = new OrderItemRequest
                {
                    OrderId = _context.OrderId,
                    Count = ds.Count,
                    ProductId = _context.GetProductId(ds.ProductIndex)
                };

                await _provider.AddItem(request);
            }
        }

        [When(@"Cancel items as follow")]
        public async Task WhenCancelItemsAsFollow(Table table)
        {
            var dsc = table.CreateSet<CancelOrderItemDataSource>();

            foreach (var ds in dsc)
            {
                var request = new OrderItemRequest
                {
                    OrderId = _context.OrderId,
                    Count = ds.Count,
                    ProductId = _context.GetProductId(ds.ProductIndex)
                };

                await _provider.Cancel(request);
            }
        }

        [When(@"Checkout order")]
        public async Task WhenCheckoutOrder()
        {
            _context.Bill =  await _provider.Checkout(_context.OrderId);
        }
    }
}