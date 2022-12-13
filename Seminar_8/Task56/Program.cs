// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Console.Write("Введите количество строк в массиве: ");
int numOfStr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите количество столбцов в массиве: ");
int numOfCol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] twoDimArray = FillDimArray(numOfStr, numOfCol);

PrintDimArray(twoDimArray);
Console.WriteLine();


int[,] FillDimArray(int str, int col)
{
    int[,] array = new int[str, col];

    for (int i = 0; i < array.GetLength(0); i++)

    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}


void PrintDimArray(int[,] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayForPrint[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] sumStrArray = new int[numOfStr];
for (int i = 0; i < numOfStr; i++)
{
    int total = 0;
    for (int j = 0; j < numOfCol; j++)
    {
        total += twoDimArray[i, j];
    }
    sumStrArray[i] = total;
}
Console.WriteLine(string.Join(",  ", sumStrArray));

int min = 10 * numOfCol;
int line = 0;
for (int i = 0; i < numOfStr; i++)
{
    if (sumStrArray[i] < min)
    {
        min = sumStrArray[i];
        line = i + 1;
    }
}
Console.WriteLine($"Вывод строки с наименьшей суммой элементов: {line} строка");
