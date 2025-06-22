using System;

class Program
{
    static void Main()
    {
        PaymentContext context = new PaymentContext();

        context.SetPaymentStrategy(new CreditCardPayment("1234-5678-9876-5432"));
        context.ExecutePayment(100.00m);

        context.SetPaymentStrategy(new PayPalPayment("user@example.com"));
        context.ExecutePayment(250.50m);
    }
}
