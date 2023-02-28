using KitchenDistributedSystem.DataAccess;
using KitchenDistributedSystem.Enums;
using KitchenDistributedSystem.Factory;
using KitchenDistributedSystem.Model;
using Microsoft.EntityFrameworkCore;

namespace KitchenDistributedSystem.Helper
{
    public class Grill : IArea
    {
        public IOrderFactory _orderFactory;

        public Grill(IOrderFactory orderFactory)
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
