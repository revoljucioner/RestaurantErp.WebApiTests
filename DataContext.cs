using RestaurantErp.Core.Models.Bill;
using System.Collections.Concurrent;

namespace RestaurantErp.WebApiTests
{
    public class DataContext
    {
        private ConcurrentDictionary<int, Guid> _productIdByIndex = new ConcurrentDictionary<int, Guid>();

        public void AddProduct(int index, Guid id)
        {
            _productIdByIndex[index] = id;
        }

        public Guid GetProductId(int index)
        {
            return _productIdByIndex[index];
        }

        public Guid OrderId { get; set; }
        public BillExternal Bill { get; set; }
        public DateTime DiscountCreationMoment { get; set; }
    }
}
