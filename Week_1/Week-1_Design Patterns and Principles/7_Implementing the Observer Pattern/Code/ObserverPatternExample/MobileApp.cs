using System;

public class MobileApp : Observer
{
    private string _name;

    public MobileApp(string name)
    {
        _name = name;
    }

    public void Update(string stockSymbol, decimal newPrice)
    {
        Console.WriteLine($"[MobileApp - {_name}] {stockSymbol} is now ${newPrice}");
    }
}