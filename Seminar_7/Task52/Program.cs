// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Console.Write("Введите количество строк: ");
int str = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] twoDimArray = new int[str, col];

for (int i = 0; i < str; i++)
{
    for (int j = 0; j < col; j++)
    {
        twoDimArray[i, j] = new Random().Next(10, 90);
        Console.Write(twoDimArray[i, j] + "    ");
    }
    Console.WriteLine();
}
double[] averageArray = new double[col];

for (int j = 0; j < col; j++)
{
    double average = 0;
    double sum = 0;

    for (int i = 0; i < str; i++)
    {
        sum = sum + twoDimArray[i, j];
    }
    average = sum / str;

    averageArray[j] = Math.Round(average, 1);
}
Console.WriteLine();
Console.Write(string.Join("; ", averageArray));
Console.WriteLine();