// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Не используя Math.Pow

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());
int natural = 1;

for (int i = 1; i <= b; i++)
{
    natural = natural * a;
}
Console.WriteLine();
Console.WriteLine("{0} ^ {1}  = {2}", a, b, natural);
