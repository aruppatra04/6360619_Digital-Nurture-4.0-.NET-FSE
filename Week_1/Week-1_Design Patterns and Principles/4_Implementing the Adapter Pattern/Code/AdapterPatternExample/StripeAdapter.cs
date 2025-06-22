public class StripeAdapter : IPaymentProcessor
{
    private readonly Stripe _stripe;

    public StripeAdapter(Stripe stripe)
    {
        _stripe = stripe;
    }


    public void ProcessPayment(decimal amount)
    {
        _stripe.SendPayment(amount);
    }
}