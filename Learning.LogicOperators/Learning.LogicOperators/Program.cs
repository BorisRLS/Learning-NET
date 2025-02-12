

Console.WriteLine("Введите первое целое число");
int.TryParse(Console.ReadLine(), out int a);
Console.WriteLine("Введите второе целое число");
int.TryParse(Console.ReadLine(), out int b);
Console.WriteLine("Введите третье целое число");
int.TryParse(Console.ReadLine(), out int c);

if (a > b && a > c)
{
    Console.WriteLine(a);
    int a1 = (a & 1);
    switch (a1)
    {
        case 0:
            Console.WriteLine("Число - " + a);
                Console.WriteLine("Четное");
            break;
        case 1:
            Console.WriteLine("Число - " + a);
            Console.WriteLine("Нечетное");
            break;
    }
}
else if (b > c)
{
    Console.WriteLine(b);
    int b1 = (b & 1);
    switch (b1)
    {
        case 0:
            Console.WriteLine("Число - " + b);
            Console.WriteLine("Четное");
            break;
        case 1:
            Console.WriteLine("Число - " + b);
            Console.WriteLine("Нечетное");
            break;

    }
}
else
{
    Console.WriteLine(c);
    int c1 = (c & 1);
    switch (c1)
    {
        case 0:
            Console.WriteLine("Число - " + c);
            Console.WriteLine("Четное");
            break;
        case 1:
            Console.WriteLine("Число - " + c);
            Console.WriteLine("Нечетное");
            break;

    }


}
string aresult = (a < 100) ? "Меньше 100" : "Больше 100";
string bresult = (b < 100) ? "Меньше 100" : "Больше 100";
string cresult = (c < 100) ? "Меньше 100" : "Больше 100";
Console.WriteLine("Первое число "+aresult);
Console.WriteLine("Второе число "+bresult);
Console.WriteLine("Третье число "+cresult);