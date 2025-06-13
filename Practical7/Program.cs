using System;

class Practice7_Var2
{
    static void Main()
    {
        Console.Write("Введіть розмір квадратної матриці (N): ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Розмір має бути додатнім!");
            return;
        }

        int[,] matrix = new int[n, n];
        Random rand = new Random();

        Console.WriteLine("\nЗгенерована матриця:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = rand.Next(1, 10); 
                Console.Write($"{matrix[i, j],4}");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < n; i++)
        {
            int sum = matrix[0, i] + matrix[n - 1, i];
            matrix[i, n - 1] = sum; 
        }

        Console.WriteLine("\nМодифікована матриця:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{matrix[i, j],4}");
            }
            Console.WriteLine();
        }
    }
}
