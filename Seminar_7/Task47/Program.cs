// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами от -10,0 до 10,0.

// m = 3, n = 4.

// 0,5 7,0 -2,0 -0,2

// 1,0 -3,3 8,0 -9,9

// 8,0 7,8 -7,1 9,0


Console.Clear();
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");
Console.WriteLine();

double[,] array = new double[m, n];

void FillTwoDimensionalDoubleArray(double[,] array) // Функция заполнение двумерного массива вещественными числами
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round((new Random().Next(-10, 11) + new Random().NextDouble()), 1);
        }
    }
    return;
}

void PrintTwoDimensionalDoubleArray(double[,] array) // Функция вывода вещественных чисел двумерного массива
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    return;
}

FillTwoDimensionalDoubleArray(array);

PrintTwoDimensionalDoubleArray(array);