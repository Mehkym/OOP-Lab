// See https://aka.ms/new-console-template for more information
using Lab02;

Console.WriteLine("Лабораторна 3. Масиви обєктів");

MaterialPoint[] array = new MaterialPoint[3];
    

for (int i = 0; i < array.Length; i++)
{
    array[i] = new MaterialPoint();
    Console.WriteLine($"Введіть координати і швидкість для точки {i + 1}:");
    array[i].Input();
}

Console.Write($"Введіть час = ");

double time = double.Parse(Console.ReadLine());


for (int i = 0; i < array.Length; i++) 
{
    if (array[i].IsInFirstOctant(time))
    {
        Console.WriteLine($"Точка N° {i + 1} потрапляє в перший Октант через час {time}");
    }
}

//    Створити масив об’єктів класу „матеріальна точка”.
//    Кожна точка характеризується координатами початкового пололження та
//    вектором рівномірної швидкості.
//    Визначити номера точок,
//    які за введений користувачем час t попадають в перший октант.