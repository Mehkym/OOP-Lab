// See https://aka.ms/new-console-template for more information
using Lab02;

Console.WriteLine("Об'єкт матеріальна точка");
MaterialPoint point = new MaterialPoint(3, -9, 2.5, 1, 2, 3);

Console.WriteLine($"x = {point.GetX()}");
Console.WriteLine($"y = {point.GetY()}");
Console.WriteLine($"z = {point.GetZ()}");

Console.WriteLine();

Console.WriteLine($"vx = {point.GetVX()}");
Console.WriteLine($"vy = {point.GetVY()}");
Console.WriteLine($"vz = {point.GetVZ()}");

Console.WriteLine();

Console.Write($"Введіть час для першої точки = ");

double time = double.Parse( Console.ReadLine() );

Console.WriteLine($"Чи точка потрапляє у перший октант через час {time}: {point.IsInFirstOctant(time)}");

MaterialPoint point2 = new MaterialPoint();

Console.WriteLine();

Console.WriteLine($"Введи координати другої точки = ");


point2.Input();

point2.Print();

Console.Write($"Введіть час для другої точки = ");

double time2 = double.Parse(Console.ReadLine());

Console.WriteLine($"Чи точка потрапляє у перший октант через час {time2}: {point2.IsInFirstOctant(time2)}");


//    Створити об’єкт класу „матеріальна точка”.
//    Точка характеризується координатами початкового положення та
//    вектором рівномірної швидкості.
//    Визначити за допомогою методу класу,
//    чи за введений користувачем час t попадають в перший октант.