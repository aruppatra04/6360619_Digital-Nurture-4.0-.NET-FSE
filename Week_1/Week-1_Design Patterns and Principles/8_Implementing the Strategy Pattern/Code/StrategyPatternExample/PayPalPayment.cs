using System;

public class PayPalPayment : PaymentStrategy
{
    private string _email;

    public PayPalPayment(string email)
    {
        _email = email;
    }

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid ${amount} using PayPal account: {_email}");
    }
}
