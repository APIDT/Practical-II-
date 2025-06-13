using System;

class Practice3_Var2
{
    static void Main()
    {
        double a = 1.5;
        double x = 0.8;

        Console.WriteLine("|   x   |        y        |");
        Console.WriteLine("|-------|-----------------|");

        while (x <= 2.0001) // запас на похибку double
        {
            double y;

            if (x < 1.3)
            {
                y = Math.PI * x * x - 7 / (x * x);
            }
            else if (Math.Abs(x - 1.3) < 0.00001)
            {
                y = a * x * x + 7 * Math.Sqrt(x);
            }
            else
            {
                y = Math.Log10(x + 7 * Math.Sqrt(x));
            }

            Console.WriteLine($"| {x,5:F1} | {y,15:F6} |");
            x += 0.1;
        }

        Console.WriteLine("|-------|-----------------|");
    }
}
