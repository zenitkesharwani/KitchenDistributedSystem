using KitchenDistributedSystem.Factory;

namespace KitchenDistributedSystem.Helper
{
    public class AreaFactory
    {
        public IOrderFactory _orderFactory;
        public AreaFactory(IOrderFactory orderfactory)
        {
            _orderFactory = orderfactory;
        }

        public IArea Create(string category)
        {
            switch (category)
            {
                case "Fish":
                    return new Fish(_orderFactory);

                case "Grill":
                    return new Grill(_orderFactory);

                case "Salad":
                    return new Salad(_orderFactory);

                case "Drink":
                    return new Drink(_orderFactory);

                case "Desert":
                    return new Dessert(_orderFactory);
                    
                default: return new Fish(_orderFactory);
            }
        }
    }
}
