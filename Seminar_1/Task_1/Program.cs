// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
string str = Console.ReadLine();
int number1 = int.Parse(str);

Console.WriteLine("Введите второе число: ");
str = Console.ReadLine();
int number2 = int.Parse(str);

if (number1 < number2)
{
    Console.WriteLine("Максимальное число равно: " + number2);
    Console.WriteLine("Минимальное число равно: " + number1);
}
else if (number1 > number2)
{
    Console.WriteLine("Максимальное число равно: " + number1);
    Console.WriteLine("Минимальное число равно: " + number2);
}
else
{
    Console.WriteLine("Числа равны");
}