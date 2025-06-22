public static class Forecast
{
    // Recursive function to calculate future value
    // formula: futureValue = presentValue * (1 + growthRate)^years
    public static double PredictFutureValue(double presentValue, double growthRate, int years)
    {
        if (years == 0)
            return presentValue;

        return (1 + growthRate) * PredictFutureValue(presentValue, growthRate, years - 1);
    }

    // Optimized version using memoization
    public static double PredictFutureValueMemo(double presentValue, double growthRate, int years, Dictionary<int, double> memo)
    {
        if (years == 0)
            return presentValue;

        if (memo.ContainsKey(years))
            return memo[years];

        double result = (1 + growthRate) * PredictFutureValueMemo(presentValue, growthRate, years - 1, memo);
        memo[years] = result;
        return result;
    }
}
