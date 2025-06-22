using System;

class Program
{
    static void Main()
    {
        IPaymentProcessor paypalProcessor = new PayPalAdapter(new PayPal());
        paypalProcessor.ProcessPayment(100.50m);

        IPaymentProcessor stripeProcessor = new StripeAdapter(new Stripe());
        stripeProcessor.ProcessPayment(250.75m);
    }
}
