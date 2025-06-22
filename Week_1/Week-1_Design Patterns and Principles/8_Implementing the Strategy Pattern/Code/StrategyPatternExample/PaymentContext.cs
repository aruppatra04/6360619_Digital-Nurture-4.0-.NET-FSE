public class PaymentContext
{
    private PaymentStrategy _paymentStrategy = null;

    public void SetPaymentStrategy(PaymentStrategy strategy)
    {
        _paymentStrategy = strategy;
    }

    public void ExecutePayment(decimal amount)
    {
        if (_paymentStrategy == null)
        {
            Console.WriteLine("Payment strategy not set.");
            return;
        }
        _paymentStrategy.Pay(amount);
    }
}
