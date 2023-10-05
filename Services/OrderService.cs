using ProvaPub.Interfaces;
using ProvaPub.Models;

namespace ProvaPub.Services
{
	public class OrderService
	{
		private readonly PaymentRegister _paymentRegister;

		public OrderService(PaymentRegister paymentRegister)
		{
			_paymentRegister = paymentRegister;
		}

		public async Task<Order> PayOrder(string paymentMethod, decimal paymentValue, int customerId)
		{
			var paymentProcessor = _paymentRegister.GetPayment(paymentMethod);

			return await paymentProcessor.ProcessPayment(paymentValue);

		}
	}
}
