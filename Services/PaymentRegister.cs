using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.Identity.Client;
using ProvaPub.Interfaces;
using ProvaPub.PaymentOptions;

namespace ProvaPub.Services
{
    public class PaymentRegister
    {
        private readonly Dictionary<string, IProcessPayment> _paymentRegister = new Dictionary<string, IProcessPayment>();

        public PaymentRegister()
        {
            _paymentRegister["pix"] = new PixPayment();
            _paymentRegister["creditcard"] = new CreditCardPayment();
            _paymentRegister["paypal"] = new PaypalPayment();
        }

        public IProcessPayment GetPayment(string paymentMethod)
        {
            if (_paymentRegister.TryGetValue(paymentMethod, out var process))
            {
                return process;
            }
            else
            {
                throw new Exception("Erro no método pagamento");
            }
        }
    }
}
