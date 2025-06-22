public class PayPalAdapter : IPaymentProcessor
{
    private readonly PayPal _payPal;

    public PayPalAdapter(PayPal payPal)
    {
        _payPal = payPal;
    }

    public void ProcessPayment(decimal amount)
    {
        _payPal.MakePayment(amount);
    }
}