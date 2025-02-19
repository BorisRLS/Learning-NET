using Learning.Generic;

var MeatList1 = new Meat<decimal>("Свинина", 250.0M, 50.0M);
var MeatList2 = new Meat<decimal>("Говядина", 250.0M, 50.0M);
var MeatList3 = new Meat<decimal>("Баранина", 250.0M, 50.0M);

var rnd=new Random();

for (var j = 0; j < 50; j++)
{
    if (MeatList1.Volume >= 5)
    {
        MeatList1 = MeatList1 - rnd.Next(0, 5);
    }
    else
    {
        MeatList1.PrintHistory();
        Console.WriteLine($"Требуется пополнить запасы {MeatList1._name}");
        break;
    }
}
for (var j = 0; j < 50; j++)
{
    if (MeatList2.Volume >= 5)
    {
        MeatList2 = MeatList2 - rnd.Next(0, 5);
    }
    else
    {
        MeatList1.PrintHistory();
        Console.WriteLine($"Требуется пополнить запасы {MeatList2._name}");
        break;
    }
}
for (var j = 0; j < 50; j++)
{
    if (MeatList3.Volume >= 5)
    {
        MeatList3 = MeatList3 - rnd.Next(0, 5);
    }
    else
    {
        MeatList1.PrintHistory();
        Console.WriteLine($"Требуется пополнить запасы {MeatList3._name}");
        break;
    }
}

