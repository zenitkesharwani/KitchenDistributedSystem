using KitchenDistributedSystem.DataAccess;
using KitchenDistributedSystem.Enums;
using Microsoft.EntityFrameworkCore;

namespace KitchenDistributedSystem.Factory
{
    public class OrderFactory : IOrderFactory
    {
        public OrderContext _orderContext;
        public OrderFactory(OrderContext orderContext)
        {
            _orderContext = orderContext;

        }

        public Order getOrder(long id)
        {
            return _orderContext.Orders.First(order => order.Id == id);
        }

        public void saveOrder(Order order)
        {
            _orderContext.Orders.Add(order);
        }

        public void updateOrder(Order order, OrderStatus orderStatus)
        {
            order.Status = orderStatus.ToString();
            _orderContext.SaveChanges();
        }
    }
}
