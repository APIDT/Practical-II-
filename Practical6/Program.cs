using System;

class Practice6_Var2
{
    static void Main()
    {
        Console.Write("Введіть кількість рядків (N ≤ 20): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введіть кількість стовпців (M ≤ 15): ");
        int m = int.Parse(Console.ReadLine());

        if (n > 20 || m > 15 || n <= 0 || m <= 0)
        {
            Console.WriteLine("Неправильні розміри матриці!");
            return;
        }

        int[,] matrix = new int[n, m];
        Random rand = new Random();

        Console.WriteLine("\nЗгенерована матриця:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = rand.Next(-10, 51); // числа від -10 до 50 включно
                Console.Write($"{matrix[i, j],4}");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nРезультат:");
        Console.WriteLine("Сума\tКількість");

        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            int count = m; // оскільки всі рядки однакової довжини

            for (int j = 0; j < m; j++)
            {
                sum += matrix[i, j];
            }

            Console.WriteLine($"{sum}\t{count}");
        }
    }
}
