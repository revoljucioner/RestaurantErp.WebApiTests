using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace RestaurantErp.WebApiTests.StepDefinitions.Asserts
{
    [Binding]
    public class BillAsserts
    {
        private readonly DataContext _context;

        public BillAsserts(DataContext context)
        {
            _context = context;
        }

        [Then(@"Bill is as follow")]
        public void ThenBillIsAsFollow(Table table)
        {
            var ds = table.CreateInstance<BillDataSource>();

            var expected = new
            {
                Amount = ds.Amount,
                AmountDiscounted = ds.AmountDiscounted,
                Discount = ds.Discount,
                Service = ds.Service,
                Total = ds.Total,
                OrderId = _context.OrderId
            };

            var actual = new
            {
                _context.Bill.Amount,
                _context.Bill.AmountDiscounted,
                _context.Bill.Discount,
                _context.Bill.Service,
                _context.Bill.Total,
                _context.Bill.OrderId
            };

            Assert.AreEqual(expected, actual);
        }
    }

    public class BillDataSource
    {
        public decimal Amount { get; set; }

        public decimal Discount { get; set; }

        public decimal AmountDiscounted { get; set; }

        public decimal Service { get; set; }

        public decimal Total { get; set; }
    }
}
