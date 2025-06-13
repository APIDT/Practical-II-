using System;
class KievanRus
{
    static void Main()
    {
        Console.WriteLine("хрещення Русi вiдбулося в 988р.");

        Console.WriteLine("Якій зараз рік?");
        string a = Console.ReadLine();
        int b = int.Parse(a);

        int year = b - 988;

        Console.WriteLine($"Минуло років з хрещення русі {year}");
        


    }
}