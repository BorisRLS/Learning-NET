//Delegates

//Делегаты - указатель на метод (коллекция функций или одна функция)
//Обращение к делегатам происходит через методы

public delegate void MyDelegate();
public delegate int ValueDelegate(int i);




class LearningDelegates
{

    static void Main(string[] args)
    {
        MyDelegate myDelegate1 = Method1;
        myDelegate1 += Method4;
        Console.WriteLine("Вызов делегата 1");
        myDelegate1();
        MyDelegate myDelegate2 = new MyDelegate(Method2);
        myDelegate2 += Method2;
        myDelegate2 += Method2;
        myDelegate2 += Method2;
        myDelegate2 -= Method2;
        Console.WriteLine("Вызов делегата 2");
        myDelegate2();
        MyDelegate myDelegate3 = myDelegate1 + myDelegate2;
        Console.WriteLine("Вызов делегата 3");
        myDelegate3();
        Console.WriteLine("Вызов делегата ValueDelegate");
        var valueDelegate = new ValueDelegate(Method5);
        valueDelegate((new Random()).Next(10, 50));

        //Заранее созданные делегаты:
        //Делегаты для методов не возвращающих значения (Метод должен иметь возвращаемое значение - "void")
        //public delegate void Action();
        Action ActionDelegate = Method6;
        Console.WriteLine("Вызов делегата ActionDelegate");
        ActionDelegate();
        //public delegate void Action(int);
        Action<int> ActionDelegate2 = Method7;
        Console.WriteLine("Вызов делегата ActionDelegate2 включающий метод возвращающий значение");
        if (ActionDelegate2 != null)
            
        ActionDelegate2(15);
        //или ActionDelegate2?.Invoke(15);


        //Делегаты возвращающие значения
        //public delegate bool Predicate<T>(T value);
        //static void Main()
        //{
        //    // Создаём делегат Predicate<int>, который указывает на метод IsEven
        //    Predicate<int> isEvenPredicate = IsEven;

        //    // Проверяем число 10
        //    int number = 10;
        //    bool result = isEvenPredicate(number);
        //    Console.WriteLine($"Число {number} чётное? {result}");

        //    // Используем Predicate<T> для фильтрации списка чисел
        //    List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //    List<int> evenNumbers = numbers.FindAll(isEvenPredicate);

        //    Console.WriteLine("Чётные числа в списке: " + string.Join(", ", evenNumbers));
        //}

        //    // Метод, который соответствует сигнатуре Predicate<T>
        //      public static bool IsEven(int num)
        //      {
        //       return num % 2 == 0;
        //      }


        //public delegate int(Задается тип возвращаемого значения) Func(тип принимаемого значения)(string value);
        //Func<string, int(возвращаемое значение)> func;
        // Создаём делегат Func<string, int>, который указывает на метод StringLength
        Console.WriteLine("Вызов делегата func");
        Func<string, int> func = StringLength;

        // Проверяем длину строки
        string text = "Hello, world!";
        int length = func(text);

        Console.WriteLine($"Длина строки \"{text}\" = {length}");
    }

    // Метод принимает строку и возвращает её длину
    public static int StringLength(string input)
    {
        return input.Length;
    }


    public static void Method1()
    {
        Console.WriteLine("Method 1");
    }
    public static void Method2()
    {
        Console.WriteLine("Method 2");
    }
    public static void Method3()
    {
        Console.WriteLine("Method 3");
    }
    public static void Method4()
    {
        Console.WriteLine("Method 4");
    }
    public static int Method5(int i)
    {
        Console.WriteLine(i);
        return i;
    }

    public static void Method6()
    {
        Console.WriteLine("Action delegate");
    }
    public static void Method7(int j)
    {
        Console.WriteLine(j);

    }

}

