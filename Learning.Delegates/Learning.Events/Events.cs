using System;

namespace Learning.Events
{ 
    class Events
{
    //public event Action EventAction;
    //Директива для сворачивания кода:
    #region TestRegion






    #endregion
    static void Main(string[] args)
    {

            Person person = new Person
            {
                Name = "Test"
            };
        person.GoToSleep += Person_GoToSleep;
            person.DoWork += Person_DoWork;
        person.CheckTime(DateTime.Parse("07.03.2025 11:30:00"));
        person.CheckTime(DateTime.Parse("07.03.2025 04:30:00"));


    }

        private static void Person_DoWork(object? sender, EventArgs e)
        {
            if (sender is Person)
            {
                Console.WriteLine($"{((Person)sender).Name} пошел на работу");
            }
        }

        private static void Person_GoToSleep()
    {
        Console.WriteLine("Пора спать");
    }
}
}