
using KitchenDistributedSystem.Factory;
using KitchenDistributedSystem.Model;
using Microsoft.EntityFrameworkCore;

namespace KitchenDistributedSystem.Helper
{
    public class Dessert : IArea
    {
        public IOrderFactory _orderFactory;
        public Dessert(IOrderFactory orderFactory)
        {
            _orderFactory = orderFactory;   
        }

        public string notifyStatus()
        {
            return "Update Client for Order is Ready";
        }

        public void processOrder(OrderDto order)
        {
            
        }

    }
}
