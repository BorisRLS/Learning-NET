
// Реализация интерфейса перемещения для самолета и машины

using Learning.Interfaces;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        var cars = new List<IMove>();
        var planners = new List<IFly>();

        cars.Add(new Car());
        planners.Add(new Planers());

        foreach (var car in cars)
        {
            Console.WriteLine(car.Move(1500));
        }
        foreach (var plann in planners)
        {
            Console.WriteLine(plann.Fly(1500));
            Console.WriteLine(((Planers)plann).Move(1500));
        }


    }
}