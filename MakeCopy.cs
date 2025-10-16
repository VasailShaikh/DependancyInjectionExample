using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTApp
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(double amount);
    }

    public class CreditCardPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount}");
        }
    }

    public class UPIPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing UPI payment of {amount}");
        }
    }
    public class CashPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing Cash payment of {amount}");
        }
    }
    public class OrderService
    {
        private readonly IPaymentProcessor _paymentProcessor;
        public OrderService(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }
        public void PlaceOrder(double amount)
        {
            _paymentProcessor.ProcessPayment(amount);
        }        
    }
}
