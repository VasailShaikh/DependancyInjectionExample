using System.Reflection;
using TESTApp;

// See https://aka.ms/new-console-template for more information

OrderService order = new OrderService(new CreditCardPaymentProcessor());
OrderService order1 = new OrderService(new UPIPaymentProcessor());
OrderService order2 = new OrderService(new CashPaymentProcessor());
//MK.PrintXerox("Printing");
order.PlaceOrder(5000.20);
order1.PlaceOrder(5000.20);
order2.PlaceOrder(5000.20);

