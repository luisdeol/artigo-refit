using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploRefitApis.Payments.Models
{
    public class ProcessPaymentInputModel
    {
        public int OrderId { get; set; }
        public decimal TotalAmount { get; set; }
        public string CreditCardNumber { get; set; }
        public string CVV { get; set; }
    }
}
