using System;

public class WebApp : Observer
{
    private string _name;

    public WebApp(string name)
    {
        _name = name;
    }

    public void Update(string stockSymbol, decimal newPrice)
    {
        Console.WriteLine($"[WebApp - {_name}] {stockSymbol} is now ${newPrice}");
    }
}