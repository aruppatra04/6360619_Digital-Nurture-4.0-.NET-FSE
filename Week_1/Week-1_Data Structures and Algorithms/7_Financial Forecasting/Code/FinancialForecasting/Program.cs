using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        double presentValue = 1000.0; // starting amount
        double growthRate = 0.05;     // 5% annual growth
        int years = 5;

        Console.WriteLine("Recursive Prediction:");
        double result = Forecast.PredictFutureValue(presentValue, growthRate, years);
        Console.WriteLine($"Future value after {years} years: {result:F2}");

        Console.WriteLine();

        Console.WriteLine("Memoized Recursive Prediction:");
        var memo = new Dictionary<int, double>();
        double optimizedResult = Forecast.PredictFutureValueMemo(presentValue, growthRate, years, memo);
        Console.WriteLine($"Future value after {years} years (memoized): {optimizedResult:F2}");
    }
}
