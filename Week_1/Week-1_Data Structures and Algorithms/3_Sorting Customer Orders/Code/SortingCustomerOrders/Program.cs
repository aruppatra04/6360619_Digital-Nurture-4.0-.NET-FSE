using System;

class Program
{
    static void Main()
    {
        Order[] orders1 = new Order[]
        {
            new Order { OrderId = 101, CustomerName = "Alice", TotalPrice = 250.50 },
            new Order { OrderId = 102, CustomerName = "Bob", TotalPrice = 120.00 },
            new Order { OrderId = 103, CustomerName = "Charlie", TotalPrice = 300.00 },
            new Order { OrderId = 104, CustomerName = "Diana", TotalPrice = 180.75 }
        };

        Order[] orders2 = (Order[])orders1.Clone(); // quick sort

        Console.WriteLine("Bubble Sort by Total Price:");
        SortAlgorithms.BubbleSort(orders1);
        foreach (var order in orders1)
            Console.WriteLine(order);

        Console.WriteLine("\nQuick Sort by Total Price:");
        SortAlgorithms.QuickSort(orders2, 0, orders2.Length - 1);
        foreach (var order in orders2)
            Console.WriteLine(order);
    }
}
