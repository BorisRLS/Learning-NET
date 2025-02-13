using System.Threading.Channels;

var list = new List<int>();
for (var i = 0; i < 15; i++)
{
    if(int.TryParse(Console.ReadLine(), out int result))
        {  list.Add(result); }
    else { Console.WriteLine("Введите целое число"); }
}
var sum = 0;
for (var i = 0;i < list.Count;i++)
{
    sum += list[i];
}
Console.WriteLine("Сумма всех чисел "+sum);
var ant = 0;
var j = 0;
while(j <list.Count)
{
    ant -= list[j];
    j++;
}
Console.WriteLine("Разность всех чисел "+ant);
var umn = 1;
var k = 0;
do
{
    umn=umn*list[k];
    k++;
}
while(k<list.Count);
Console.WriteLine("Произведение всех чисел "+ umn);
foreach(var item in list)
{
    Console.WriteLine(item);
}