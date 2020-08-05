using ExemploRefitApis.Payments.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploRefitApis.Payments.Controllers
{
    [Route("api/{controller}")]
    public class PaymentsController : ControllerBase
    {
        private List<Payment> _payments = new List<Payment>
        {
            new Payment(1, 100, 1),
            new Payment(2, 200, 2),
            new Payment(3, 300, 3)
        };

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var payment = _payments.SingleOrDefault(p => p.Id == id);

            if (payment == null)
            {
                return NotFound();
            }

            return Ok(payment);
        }

        [HttpPost]
        public IActionResult Create([FromBody]ProcessPaymentInputModel processPaymentInputModel)
        {
            var randomId = new Random().Next(1, 3);

            return CreatedAtAction(nameof(Get), new { id = randomId }, new ProcessPaymentResultViewModel(randomId, true, new List<string>()));
        }
    }
}
