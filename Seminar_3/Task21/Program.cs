// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.Write("Введите координаты точки А(x): ");
double Ax = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите координаты точки А(y): ");
double Ay = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите координаты точки А(z): ");
double Az = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine();

Console.Write("Введите координаты точки B(x): ");
double Bx = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите координаты точки B(y): ");
double By = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите координаты точки B(z): ");
double Bz = double.Parse(Console.ReadLine());
Console.WriteLine();

double AB = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2));

Console.WriteLine( "Расстояние между двумя точками в 3D пространстве состовляет: "+ AB);
