using KitchenDistributedSystem.DataAccess;
using KitchenDistributedSystem.Model;

namespace KitchenDistributedSystem.Helper
{
    public interface IArea
    {

        void processOrder(OrderDto order);
        string notifyStatus();

    }
}
