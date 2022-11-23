// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру, обозначающую день недели: ");
int week = int.Parse(Console.ReadLine());

switch (week)
{
    case 1:
    Console.WriteLine(week);
    Console.Write("Понедельник - будний день");
    break;
    case 2:
    Console.WriteLine(week);
    Console.Write("Вторник - будний день");
    break;
    case 3:
    Console.WriteLine(week);
    Console.Write("Среда - будний день");
    break;
    case 4:
    Console.WriteLine(week);
    Console.Write("Четверг - будний день");
    break;
    case 5:
    Console.WriteLine(week);
    Console.Write("Пятница - будний день");
    break;
    case 6:
    Console.WriteLine(week);
    Console.Write("Суббота - выходной день");
    break;
    case 7:
    Console.WriteLine(week);
    Console.Write("Воскресенье - выходной день");
    break;
    default:
    Console.Write("Введите цифру от 1 до 7");
    break;
}