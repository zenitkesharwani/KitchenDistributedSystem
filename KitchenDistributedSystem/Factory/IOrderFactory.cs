using KitchenDistributedSystem.DataAccess;
using KitchenDistributedSystem.Enums;
using KitchenDistributedSystem.DataAccess;

namespace KitchenDistributedSystem.Factory
{
    public interface IOrderFactory
    {

        void updateOrder(Order order , OrderStatus orderStatus);

        Order getOrder(long id);

        void saveOrder(Order order);
    }
}
