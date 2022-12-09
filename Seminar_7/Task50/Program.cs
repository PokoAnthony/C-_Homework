// Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы числа в двумерном массиве или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.Clear();

Console.Write("Укажите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = new Random().Next(10, 100);
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + " ");
    Console.WriteLine();
}
Console.WriteLine();

Console.Write("Введите число от 10 до 100: ");
int indexNum = Convert.ToInt32(Console.ReadLine());

int ind1 = 0;
int ind2 = 0;
if (indexNum >= 10 && indexNum < 100)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == indexNum)
            {
                ind1 = i;
                ind2 = j;
                Console.WriteLine();
                Console.WriteLine($"Число: {indexNum} находится под индексами с адресом [{ind1},{ind2}]");
            }
        }
    }
}

else
{
    Console.Write("Введите корректное число! ");
}