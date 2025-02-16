namespace Learning.ClassConstructorsProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            var Kaminskogo24 = new List<string>();

            var UserList = 0;
            while (UserList < 1)
            {
                UserList++;
                SportFitShopUser user = new SportFitShopUser(Console.ReadLine(), Console.ReadLine());
                user.SportId = UserList;
                user.CardBalance = 0;
                Console.WriteLine(user.FullSportName);
                Kaminskogo24.Add(user.FullSportName);
            }
        }
    }
}