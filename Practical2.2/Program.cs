using System;

class Program
{
    static void Main()
    {
        ReadAndPrintSquare();
    }

    static void ReadAndPrintSquare()
    {
        Console.Write("Введіть число: ");
        double num = Convert.ToDouble(Console.ReadLine());

        if (num > 10 && num < 20)
        {
            Console.WriteLine($"Квадрат числа: {num * num}");
            ReadAndPrintSquare();
        }
        else
        {
            Console.WriteLine("Число поза діапазоном. Завершення.");
        }
    }
}
