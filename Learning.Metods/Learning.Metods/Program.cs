using Learning.Metods;
using System;

class Program
{
    /* static void Main()
    {
        var user1 = new ProductCase("Novikov", "Boris", 1, 0.0, 0.0);
        var user2 = new ProductCase("Ivanov", "Petr", 2, 0.0, 0.0);
        var user3 = new ProductCase("Kazakhov", "Ivan", 3, 0.0, 0.0);
        var randomValue = new System.Random();

        for (var i = 0; i < 1000; i++)
        {
            double min = 5.0;
            double max = 10.0;
            user1.Balance += min + (randomValue.NextDouble() * (max - min));
            user2.Balance += min + (randomValue.NextDouble() * (max - min));
            user3.Balance += min + (randomValue.NextDouble() * (max - min));
        }

        Console.WriteLine(user1.FullName);
        Console.WriteLine(user2.FullName);
        Console.WriteLine(user3.FullName);
    }
    */

    //Вычисление числа фибоначчи рекурсивным методом
    /*
     static void Main(string[] args)
    {
        Console.WriteLine(Fibonacci(11));
    }
    public static int Fibonacci(int value)
    {
        if (value == 0) return 0;
        if (value == 1) return 1;
        else
        {
            return Fibonacci(value - 1) + Fibonacci(value - 2);
        }
    }
    */
    static void Main(string[] args)
    {
        var i1 = 0;
        var i2 = 1;
        var Fib = 0;
        Console.WriteLine(i1);
        Console.WriteLine(i2);
        for (var i = 1; i < 11; i++)
        {

            Fib = i2 + i1;
            i1= i2;
            i2 = Fib;
            Console.WriteLine(Fib);
        }
    }

}



