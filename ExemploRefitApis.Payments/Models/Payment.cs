using ExemploRefitApis.Payments.Enums;
using System;

namespace ExemploRefitApis.Payments.Models
{
    public class Payment
    {
        public Payment(int id, decimal totalAmount, int orderId)
        {
            Id = id;
            TotalAmount = totalAmount;
            OrderId = orderId;
            CreatedAt = DateTime.Now;
            Status = PaymentStatusEnum.Processing;
        }

        public int Id { get; private set; }
        public decimal TotalAmount { get; private set; }
        public int OrderId { get; private set; }
        public PaymentStatusEnum Status { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
