using System;

class MathStats
{
    static void Main()
    {
        double[] numbers = new double[10];
        int count = 0;

        Console.WriteLine("Введіть 10 дійсних чисел більше за 10:");

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

        double sumPositive = 0;
        int countPositive = 0;
        double productNegative = 1;
        int countNegative = 0;
        double totalSum = 0;

        foreach (double num in numbers)
        {
            totalSum += num;

            if (num > 0)
            {
                sumPositive += num;
                countPositive++;
            }

            if (num < 0)
            {
                productNegative *= num;
                countNegative++;
            }
        }

        double average = totalSum / numbers.Length;

        Console.WriteLine($"\nСума додатніх: {sumPositive}");
        Console.WriteLine($"Кількість додатніх: {countPositive}");

        if (countNegative > 0)
        {
            Console.WriteLine($"Добуток від’ємних: {productNegative}");
            Console.WriteLine($"Кількість від’ємних: {countNegative}");
        }
        else
        {
            Console.WriteLine("Від’ємних чисел не було.");
        }

        Console.WriteLine($"Середнє арифметичне: {average:F2}");
    }
}
