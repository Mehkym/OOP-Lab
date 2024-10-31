using Lab06;

Console.WriteLine("1. Коло");
Console.WriteLine("2. Сфера");

string choice = Console.ReadLine();
RoundedShape shape;
double radius;

switch (choice)
{
    case "1":
        shape = new Circle();
        shape.Input();
        break;
    case "2":
        shape = new Sphere();
        shape.Input();
        break;
    default:
        Console.WriteLine("Не вірний вибір");
        return;
}
shape.Print();

Console.WriteLine();

RoundedShape[] shapes = {new Circle(1, 2, 5), new Circle(4, -3, 9), new Sphere(1, 2, 3, 5)};

foreach (var s in shapes)
{
    s.Print();
}