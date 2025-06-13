using System;

class Math
{
    static void Main()
    {
        double[] a = new double[10];
        int count = 0;

        Console.WriteLine("Вводіть дійсні числа (буде збережено тільки ті, що > 10):");

        while (count < 10)
        {
            Console.Write("Число: ");
            double x = double.Parse(Console.ReadLine());

            if (x > 10)
            {
                a[count] = x;
                count++;
            }
            else
            {
                Console.WriteLine("Це число не більше 10 — воно не буде збережене.");
            }
        }

        Console.WriteLine("Результат:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(a[i]);
        }
    }
}
