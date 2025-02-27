
using Learning.Exception;

try
{
    List<Users> users = new List<Users>();
    users.Add(new Users("Novikov", "Boris", new DateTime(2000, 12, 5)));
    users.Add(new Users("Novikov", "Boris", new DateTime(2000, 12, 5)));

    // Проверка на совпадение данных
    foreach (var user in users)
    {
        new MyOwnException(users, user);
    }
}

catch (MyOwnException ex)
{
    // Перехват MyOwnException
    Console.WriteLine($"Ошибка: {ex.Message}");
}
catch (Exception ex)
{
    // Общий перехват других исключений
    Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
}
finally
{
    Console.WriteLine("Программа выполнена");
}