using System;

class ThreeNumber
{
    static void Main()
    {
        int a = 346;
        int b = 26;
        double c = 203.9;

        if (a > b && a > c)
        {
            Console.WriteLine($"Найбільше число {a}");
        }
        else if (b > a && b > c)
        { 
            Console.WriteLine($"Найбільше число {b}");
        }
        else if (c > a && c > b)
        { 
            Console.WriteLine($"Найбільше число {c}");
        }
    }
}
