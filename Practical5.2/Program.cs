using System;

class ProductBetweenMinMaxAbs
{
    static void Main()
    {
        int[] array = { -7, 3, -20, 5, 1, 9, -2, 0 };

        int maxAbsIndex = 0;
        int minAbsIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (Math.Abs(array[i]) > Math.Abs(array[maxAbsIndex]))
                maxAbsIndex = i;

            if (Math.Abs(array[i]) < Math.Abs(array[minAbsIndex]))
                minAbsIndex = i;
        }

        Console.WriteLine($"Максимальний за модулем: {array[maxAbsIndex]} (індекс {maxAbsIndex})");
        Console.WriteLine($"Мінімальний за модулем: {array[minAbsIndex]} (індекс {minAbsIndex})");

        // Межі між ними
        int start = Math.Min(minAbsIndex, maxAbsIndex) + 1;
        int end = Math.Max(minAbsIndex, maxAbsIndex);

        if (end - start <= 0)
        {
            Console.WriteLine("Між елементами нічого нема — добуток не обчислюється.");
            return;
        }

        int product = 1;
        for (int i = start; i < end; i++)
        {
            product *= array[i];
        }

        Console.WriteLine($"Добуток елементів між ними: {product}");
    }
}
