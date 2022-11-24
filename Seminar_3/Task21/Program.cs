// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.Writeline("Введите координаты точки А(x): ");
double firstX = double.Parse(Console.ReadLine());
Console.Writeline("Введите координаты точки А(y): ");
double firstY = double.Parse(Console.ReadLine());
Console.Writeline("Введите координаты точки А(z): ");
double firstZ = double.Parse(Console.ReadLine());

Console.Writeline("Введите координаты точки B(x): ");
double secondX = double.Parse(Console.ReadLine());
Console.Writeline("Введите координаты точки B(y): ");
double secondY = double.Parse(Console.ReadLine());
Console.Writeline("Введите координаты точки B(z): ");
double secondZ = double.Parse(Console.ReadLine());

double ab = Math.Sqrt(Math.Pow(secondX - firstX, 2) + Math.Pow(secondY - firstY, 2) + Math.Pow(secondZ - firstZ, 2));

Console.WriteLine( "ВВВ"+ ab); //"Расстояние между двумя точками в 3D пространстве: "



