using System;

class MAXMIN
{
    static void Main()
    {
        double[] numbers = new double[10];
        int count = 0;

        Console.WriteLine("Введіть 10 дійсних чисел більших за 10:");

        while (count < 10)
        {
            Console.Write($"Число {count + 1}: ");
            double num = double.Parse(Console.ReadLine());

            if (num > 10)
            {
                numbers[count] = num;
                count++;
            }
            else
            {
                Console.WriteLine("Число має бути більше за 10!");
            }
        }

        double max = numbers[0];
        double min = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max) max = numbers[i];
            if (numbers[i] < min) min = numbers[i];
        }

        Console.WriteLine($"\nМаксимальне число: {max}");
        Console.WriteLine($"Мінімальне число: {min}");
    }
}
