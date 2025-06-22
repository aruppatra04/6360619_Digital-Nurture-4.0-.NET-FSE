using System;

class Program
{
    static void Main()
    {
        StockMarket stockMarket = new("AAPL");

        Observer mobileApp1 = new MobileApp("Alice");
        Observer mobileApp2 = new MobileApp("Bob");
        Observer webApp1 = new WebApp("Dashboard");

        stockMarket.RegisterObserver(mobileApp1);
        stockMarket.RegisterObserver(mobileApp2);
        stockMarket.RegisterObserver(webApp1);

        stockMarket.UpdatePrice(150.75m);
        stockMarket.UpdatePrice(153.20m);

        stockMarket.DeregisterObserver(mobileApp2);
        stockMarket.UpdatePrice(149.80m);
    }
}
