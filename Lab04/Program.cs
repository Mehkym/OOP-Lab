//  Створити клас „ коло  ” і створити відповідні методи:
//	задання координат(x_0, y_0) центру кола та його радіусу,
//	а також виведення цих даних на екран;
//  визначення довжини кола. 
//	Створити похідний клас „сфера  ” . Перевантажити   відповідні методи:
//	задання координат   центру сфери та її радіусу,
//	а також виведення цих даних на екран;
//  визначення площі поверхні сфери. 
//	Створити об’єкти класів „коло  ” та „сфера  ”.
//	Визначити довжину кола та площу поверхні сфери.


using Lab04;
Сircle circle = new Сircle { X = 3 , Y = 4, R = 10};
circle.Print();
Console.WriteLine($"Довжина кола: {circle.Length():F2}");
Console.WriteLine();

circle.X = 2;
++circle.Y;
circle.R = 17;
circle.Print();
Console.WriteLine($"Довжина кола: {circle.Length():F2}");
Console.WriteLine();

Сircle circle2 = new Сircle { X = 6, Y = 3, R = 15 };
circle2.Print();
Console.WriteLine($"Довжина кола: {circle2.Length():F2}");
Console.WriteLine();

Sphere sphere = new Sphere { X = 1, Y = 5.12, Z = -21, R = 10};
sphere.Print();
Console.WriteLine($"Площа поверхні: {sphere.SquareFootage():F2}");



