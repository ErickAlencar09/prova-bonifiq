using ProvaPub.Interfaces;
using ProvaPub.Models;

namespace ProvaPub.PaymentOptions
{
    public class PixPayment : IProcessPayment
    {
        public async Task<Order> ProcessPayment(decimal paymentValue)
        {
            return await Task.FromResult(new Order
            {
                Value = paymentValue
            });
        }
    }
}
