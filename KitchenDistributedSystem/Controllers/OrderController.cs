using KitchenDistributedSystem.DataAccess;
using KitchenDistributedSystem.Helper;
using KitchenDistributedSystem.Model;
using Microsoft.AspNetCore.Mvc;

namespace KitchenDistributedSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {

        private readonly ILogger<OrderController> _logger;
        private readonly IAreaFactory _areaFactory;

        public OrderController(ILogger<OrderController> logger, IAreaFactory areaFactory)
        {
            _logger = logger;
            _areaFactory = areaFactory;
        }

        [HttpPost]
        public IActionResult Order(OrderDto order)
        {
            if(order == null)
            {
                throw new Exception("Invalid Order");
            }
            
            IArea area  = _areaFactory.GetArea(order.Category);
            area.processOrder(order);

            return Ok();
        }
    }
}