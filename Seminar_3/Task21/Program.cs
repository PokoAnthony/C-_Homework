// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.Write("Введите координаты точки А(x): ");
double aX = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите координаты точки А(y): ");
double aY = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите координаты точки А(z): ");
double aZ = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine();

Console.Write("Введите координаты точки B(x): ");
double bX = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите координаты точки B(y): ");
double bY = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите координаты точки B(z): ");
double bZ = double.Parse(Console.ReadLine());
Console.WriteLine();

double ab = Math.Sqrt(Math.Pow(bX - aX, 2) + Math.Pow(bY - aY, 2) + Math.Pow(bZ - aZ, 2));

Console.WriteLine("Расстояние между двумя точками в 3D пространстве состовляет: "+ ab);
