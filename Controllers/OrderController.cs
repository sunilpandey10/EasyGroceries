using Microsoft.AspNetCore.Mvc;
using EasyGroceries.API.Models;
using EasyGroceries.API.Repositories;
using EasyGroceries.API.Services;

namespace EasyGroceries.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepo;
        private readonly IOrderProcessor _orderProcessor;

        public OrderController(IOrderRepository orderRepo, IOrderProcessor orderProcessor)
        {
            _orderRepo = orderRepo;
            _orderProcessor = orderProcessor;
        }

        [HttpPost]
        public ActionResult<Order> CreateOrder([FromBody] Order order)
        {
            var processed = _orderProcessor.ProcessOrder(order);
            _orderRepo.Save(processed);
            return Ok(processed);
        }

        [HttpGet("{orderId}/shipping-slip")]
        public ActionResult<ShippingSlip> GetShippingSlip(int orderId)
        {
            var order = _orderRepo.GetById(orderId);
            if (order == null) return NotFound();

            var slip = _orderProcessor.GenerateShippingSlip(order);
            return Ok(slip);
        }
    }
}
