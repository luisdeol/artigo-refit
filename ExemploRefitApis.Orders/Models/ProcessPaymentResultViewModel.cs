using System.Collections.Generic;

namespace ExemploRefitApis.Orders.Models
{
    public class ProcessPaymentResultViewModel
    {
        public int IdPayment { get; set; }
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
    }
}
