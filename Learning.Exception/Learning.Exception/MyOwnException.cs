

namespace Learning.Exception
{
    using System;
    public class MyOwnException : Exception
    {
        public MyOwnException(List<Users> users, Users newUser) : base("Не может быть полного совпадения данных")
        {
            // Перебор пользователей и проверка на совпадение данных
            foreach (var user in users)
            {
                if (user.FirstName == newUser.FirstName && user.LastName == newUser.LastName && user.BirthDate == newUser.BirthDate)
                {
                    // Если совпадение найдено, выбрасываем исключение
                    // Но без рекурсивного вызова конструктора MyOwnException
                    throw new Exception($"Совпадение данных: {newUser.FirstName} {newUser.LastName} {newUser.BirthDate}");
                }
            }
        }
    }
}

