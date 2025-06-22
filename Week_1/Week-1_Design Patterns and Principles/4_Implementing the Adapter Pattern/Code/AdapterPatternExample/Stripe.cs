public class Stripe
{
    public void SendPayment(decimal value)
    {
        Console.WriteLine($"Stripe sent payment of ${value}");
    }
}