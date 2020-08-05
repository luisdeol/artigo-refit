using ExemploRefitApis.Orders.Models;
using Refit;
using System.Threading.Tasks;

namespace ExemploRefitApis.Orders.Services
{
    public interface IPaymentService
    {
        [Post("/api/payments")]
        Task<ProcessPaymentResultViewModel> Process(ProcessPaymentInputModel processPaymentInputModel);
        [Get("/api/payments/{id}")]
        Task<PaymentDataViewModel> GetData([AliasAs("id")]int paymentId);
    }
}
