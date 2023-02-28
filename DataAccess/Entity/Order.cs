using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public string Status { get; set; }

        public string FoodName { get; set; }

        public int Quantity { get; set; }

    }
}
