// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

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

void ArrangesDescending(int[,] arrayDes)
{
    for (int i = 0; i < arrayDes.GetLength(0); i++)
    {
        for (int j = 0; j < arrayDes.GetLength(1); j++)
        {
            for (int k = 0; k < arrayDes.GetLength(1) - 1; k++)
            {
                if (arrayDes[i, k] < arrayDes[i, k + 1])
                {
                    int temp = arrayDes[i, k + 1];
                    arrayDes[i, k + 1] = arrayDes[i, k];
                    arrayDes[i, k] = temp;
                }
            }
     
        }
    }
}

Console.Write("Введите количество строк в массиве: ");
int numOfStr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите количество столбцов в массиве: ");
int numOfCol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] arrayA = FillDimArray(numOfStr, numOfCol);
PrintDimArray(arrayA);
Console.WriteLine();
Console.WriteLine("Вывод элементов каждой строки двумерного массива по убыванию:");
ArrangesDescending(arrayA);
PrintDimArray(arrayA);