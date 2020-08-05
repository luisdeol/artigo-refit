using ExemploRefitApis.Orders.Enums;
using System;

namespace ExemploRefitApis.Orders.Models
{
    public class PaymentDataViewModel
    {
        public int Id { get; set; }
        public decimal TotalAmount { get; set; }
        public int OrderId { get; set; }
        public PaymentStatusEnum Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
