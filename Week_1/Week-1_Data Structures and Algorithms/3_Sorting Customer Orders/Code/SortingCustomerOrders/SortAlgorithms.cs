public static class SortAlgorithms
{
    // Bubble Sort
    public static void BubbleSort(Order[] orders)
    {
        int n = orders.Length;
        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (orders[j].TotalPrice > orders[j + 1].TotalPrice)
                {
                    (orders[j], orders[j + 1]) = (orders[j + 1], orders[j]);
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
    }

    // Quick Sort
    public static void QuickSort(Order[] orders, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(orders, low, high);
            QuickSort(orders, low, pi - 1);
            QuickSort(orders, pi + 1, high);
        }
    }

    private static int Partition(Order[] orders, int low, int high)
    {
        double pivot = orders[high].TotalPrice;
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (orders[j].TotalPrice < pivot)
            {
                i++;
                (orders[i], orders[j]) = (orders[j], orders[i]);
            }
        }

        (orders[i + 1], orders[high]) = (orders[high], orders[i + 1]);
        return i + 1;
    }
}
