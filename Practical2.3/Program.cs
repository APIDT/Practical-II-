using System;

class Birthday
{
    static void Main()
    {
        Console.WriteLine("Вводіть номер вашого місяця народження");
        string num = Console.ReadLine();
        int number = int.Parse(num);
        
        if (number == 12 || number == 1 || number ==  2)
        {
            Console.WriteLine("Ви народилися взимку");
        }
        else if (number == 3 || number == 4 || number == 5)
        {
            Console.WriteLine("Ви народилися весною");
        }
        else if (number == 6 || number == 7 || number == 8)
        {
            Console.WriteLine("Ви народилися влітку");
        }
        else if (number == 9 || number == 10 || number == 11)
        {
            Console.WriteLine("Ви народилися осінню");
        }
    }
}