// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите первое число: ");
string str = Console.ReadLine();
int number1 = int.Parse(str);

Console.WriteLine("Введите второе число: ");
str = Console.ReadLine();
int number2 = int.Parse(str);

Console.WriteLine("Введите третье число: ");
str = Console.ReadLine();
int number3 = int.Parse(str);
int[]numbers = {number1,number2,number3};
int maxValue = numbers.Max();
Console.WriteLine("Максимальное число: " + maxValue);


// if (number1 > number2 && number1 > number3)
// {
//     Console.WriteLine("Максимальное число равно: " + number1);
// }
// else if (number1 < number2 && number3 < number2)
// {
//     Console.WriteLine("Максимальное число равно: " + number2);
// }

// else if (number3 > number1 && number3 > number2)
// {
//     Console.WriteLine("Максимальное число равно: " + number3);
// }
// else
// {
//     Console.WriteLine("Числа равны");
// }