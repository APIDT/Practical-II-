using System;

class Program
{
    static void Main()
    {
        double num;

        while (true)
        {
            Console.Write("Введіть число: ");
            num = Convert.ToDouble(Console.ReadLine());

            if (num > 10 && num < 20)
            {
                Console.WriteLine($"Квадрат числа: {num * num}");
            }
            else
            {
                Console.WriteLine("Число поза діапазоном. Завершення.");
                break;
            }
        }
    }
}
    