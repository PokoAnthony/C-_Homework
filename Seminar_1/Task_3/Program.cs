// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число: ");
string str = Console.ReadLine();
int number = int.Parse(str);

if (number % 2 == 0)
{
    Console.WriteLine("Является четным: " + number);
}

else
{
    Console.WriteLine("Является НЕ четным: " + number);
}