using System;

class FunctionCalculator
{
    static void Main()
    {
        double A = Math.PI / 4;      
        double B = Math.PI / 2;      
        int M = 15;                  
        double H = (B - A) / M;      

        Console.WriteLine("x\t\tf(x) = sin(x)");
        Console.WriteLine("-------------------------");

        for (int i = 1; i <= M; i++)
        {
            double x = A + i * H;
            double y = Math.Sin(x);
            Console.WriteLine($"{x:F4}\t{y:F4}");
        }
    }
}
