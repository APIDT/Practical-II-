using System;
using System.Linq;

class Sum
{
    static void Main()
    {
        int[] a = { 1, 5, 29, 30, 64, 3, 1, 6, 9, 34, 23 };

        int b = a.Sum(); 

        Console.WriteLine($"Сума елементів масиву: {b}");
    }
}
