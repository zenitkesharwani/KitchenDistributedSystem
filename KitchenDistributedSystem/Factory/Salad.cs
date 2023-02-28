using KitchenDistributedSystem.DataAccess;
using KitchenDistributedSystem.Factory;
using KitchenDistributedSystem.Model;

namespace KitchenDistributedSystem.Helper
{
    public class Salad : IArea
    {
        public IOrderFactory _orderFactory;

        public Salad(IOrderFactory orderFactory)
        {
            _orderFactory = orderFactory;
        }

        public string notifyStatus()
        {
            throw new NotImplementedException();
        }

        public void processOrder(OrderDto order)
        {
            throw new NotImplementedException();
        }
    }
}
