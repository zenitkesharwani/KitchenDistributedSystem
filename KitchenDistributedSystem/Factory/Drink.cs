using KitchenDistributedSystem.DataAccess;
using KitchenDistributedSystem.Enums;
using KitchenDistributedSystem.Factory;
using KitchenDistributedSystem.Model;
using Microsoft.EntityFrameworkCore;

namespace KitchenDistributedSystem.Helper
{
    public class Drink : IArea
    {
        public IOrderFactory _orderFactory;

        public Drink(IOrderFactory orderFactory)
        {
            _orderFactory = orderFactory;
        }

        public string notifyStatus()
        {
            throw new NotImplementedException();
        }

        public void processOrder(OrderDto order)
        {
            var ord = new Order();
            ord.Quantity = order.Quantity;
            ord.FoodName = order.itemName;
            _orderFactory.saveOrder(ord);
        }
    }
}
