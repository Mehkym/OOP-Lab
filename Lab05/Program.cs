//    Написати програму, описавши батьківський та похідний класи і використавши віртуальні методи.
//    За основу візьміть попередню лабораторну і додайте віртуальні методи.
//    Використайте динамічне створення об’єктів та показчики на екземпляр класу. 
//    Продемонструвати роботу віртуальних методів на практичному прикладі
//    коли наперед невідомо який об’єкт буде створено (невідомо на етапі компіляції):


using Lab05;

Console.WriteLine("1. Коло");
Console.WriteLine("2. Сфера");

string choice = Console.ReadLine();
Сircle shape;

switch (choice)
{
	case "1":
		shape = new Сircle();
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





