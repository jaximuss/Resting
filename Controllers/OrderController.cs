using Microsoft.AspNetCore.Mvc;
using Resting.DataAccessLayer;

namespace Resting.Controllers
{
    public class OrdersController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrdersController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        // Use _orderRepository to interact with order data
    }
}
