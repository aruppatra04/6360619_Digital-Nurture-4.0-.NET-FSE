using System;
using System.Collections.Generic;

public class StockMarket : Stock
{
    private List<Observer> _observers = new();
    private string _stockSymbol;
    private decimal _stockPrice;

    public StockMarket(string stockSymbol)
    {
        _stockSymbol = stockSymbol;
    }

    public void UpdatePrice(decimal newPrice)
    {
        Console.WriteLine($"\nStockMarket: {_stockSymbol} price updated to ${newPrice}");
        _stockPrice = newPrice;
        NotifyObservers();
    }

    public void RegisterObserver(Observer observer)
    {
        _observers.Add(observer);
    }

    public void DeregisterObserver(Observer observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_stockSymbol, _stockPrice);
        }
    }
}
