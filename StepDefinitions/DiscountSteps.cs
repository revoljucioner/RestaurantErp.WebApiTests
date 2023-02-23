using BackendTestApplicationCore.Core;
using BackendTestApplicationCore.Core.Extensions;
using RestaurantErp.Core.Models.Discount;
using RestaurantErp.Core.Models.Product;
using RestaurantErp.WebApiTests.Providers;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace RestaurantErp.WebApiTests.StepDefinitions
{
    [Binding]
    public class DiscountSteps
    {
        private readonly DataContext _context;
        private readonly DiscountProvider _provider;
        private readonly HumanTimeConverter _humanTimeConverter;

        public DiscountSteps(DataContext context,
            DiscountProvider provider,
            HumanTimeConverter humanTimeConverter)
        {
            _context = context;
            _provider = provider;
            _humanTimeConverter = humanTimeConverter;
        }

        [Given(@"Set discount by time as follow")]
        public async Task GivenSetDiscountByTimeAsFollow(Table table)
        {
            var ds = table.CreateInstance<CreateDiscountDataSource>();

            var request = new DiscountByTimeSettings
            {
                ProductId = _context.GetProductId(ds.ProductIndex),
                DiscountValue = ds.DiscountValue,
                StartTime = TimeOnly.FromDateTime(_humanTimeConverter.Convert(ds.StartTime)),
                EndTime = TimeOnly.FromDateTime(_humanTimeConverter.Convert(ds.EndTime))
            };

            await _provider.Add(request);

            _context.DiscountCreationMoment = DateTime.UtcNow;
        }

        [When(@"Wait '([^']*)' seconds after discount creation")]
        public async Task WhenWaitSecondsAfterDiscountCreation(int seconds)
        {
            var rest = TimeSpan.FromSeconds(seconds) - DateTime.UtcNow.Subtract(_context.DiscountCreationMoment);

            await Task.Delay(rest);
        }
    }

    public class CreateDiscountDataSource
    {
        public int ProductIndex { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public decimal DiscountValue { get; set; }
    }
}