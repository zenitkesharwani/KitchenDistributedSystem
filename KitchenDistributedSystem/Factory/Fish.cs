using KitchenDistributedSystem.DataAccess;
using KitchenDistributedSystem.Enums;
using KitchenDistributedSystem.Factory;
using KitchenDistributedSystem.Model;
using Microsoft.EntityFrameworkCore;

namespace KitchenDistributedSystem.Helper
{
    public class Fish : IArea
    {
        public IOrderFactory _orderFactory;

        public Fish(IOrderFactory orderFactory)
        {
            _orderFactory = orderFactory;
        }

        public string notifyStatus()
        {
            return "Update Client for Order is Ready";
        }

        public void processOrder(OrderDto order)
        {
            throw new NotImplementedException();
        }
    }
}
