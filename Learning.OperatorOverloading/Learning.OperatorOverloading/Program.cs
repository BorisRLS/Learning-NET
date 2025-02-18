
using Learning.OperatorOverloading;

var a1 = new Animal("Бобик", "Вадим", 500.00);
var a2 = new Animal("Стелла", "Вадим", 300.00);
var a3 = new Animal("Бобик", "Вадим", 500.00);
var sumAnimal1 = a1 + a2;
var sumAnimal2 = a2 + a1;
Console.WriteLine(sumAnimal1);
Console.WriteLine(a1==a2);
Console.WriteLine(a1 == a3);
Console.WriteLine(sumAnimal2==sumAnimal1);