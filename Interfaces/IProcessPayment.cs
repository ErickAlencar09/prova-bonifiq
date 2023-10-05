using ProvaPub.Models;

namespace ProvaPub.Interfaces
{
    public interface IProcessPayment
    {
        Task<Order> ProcessPayment(decimal paymentValue);
    }
}
