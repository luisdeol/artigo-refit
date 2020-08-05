using ExemploRefitApis.Orders.Models;
using ExemploRefitApis.Orders.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExemploRefitApis.Orders.Controllers
{
    [Route("api/{controller}")]
    public class OrdersController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        public OrdersController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet("{orderId}/payments/{id}")]
        public async Task<IActionResult> GetPayment(int orderId, int id)
        {
            var result = await _paymentService.GetData(id);

            return Ok(result);
        }

        [HttpPost("{orderId}/payments")]
        public async Task<IActionResult> Create(int orderId, [FromBody] ProcessPaymentInputModel processPaymentInputModel)
        {
            var result = await _paymentService.Process(processPaymentInputModel);

            if(!result.Success)
            {
                return BadRequest(result.Errors);
            }

            return CreatedAtAction(nameof(GetPayment), new { orderId, id = result.IdPayment }, result);
        }
    }
}
