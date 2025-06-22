using System;

public class CreditCardPayment : PaymentStrategy
{
    private string _cardNumber;

    public CreditCardPayment(string cardNumber)
    {
        _cardNumber = cardNumber;
    }

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid ${amount} using Credit Card: {_cardNumber}");
    }
}
