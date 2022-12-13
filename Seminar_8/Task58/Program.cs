// Задача 58: Задайте два двумерных массива (от 0 до 10). Напишите программу, которая будет находить произведение двух массивов (поэлементное).
// Например, даны 2 массива:
// 2 4
// 3 2

// 3 4
// 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

Console.Clear();

Console.Write("Введите количество строк в массиве: ");
int numOfStr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите количество столбцов в массиве: ");
int numOfCol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] twoDimArrayA = new int[numOfStr, numOfCol];
int[,] twoDimArrayB = new int[numOfStr, numOfCol];
int[,] twoDimArrayC = new int[numOfStr, numOfCol];

FillDimArrayA(twoDimArrayA);
PrintDimArrayA(twoDimArrayA);
Console.WriteLine();

FillDimArrayB(twoDimArrayB);
PrintDimArrayB(twoDimArrayB);
Console.WriteLine();

FillDimArrayC(twoDimArrayC);
PrintDimArrayC(twoDimArrayC);
Console.WriteLine();


void FillDimArrayA(int[,] arrayA)
{
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayA.GetLength(1); j++)
        {
            arrayA[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintDimArrayA(int[,] arrayA)
{
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayA.GetLength(1); j++)
        {
            Console.Write($"{arrayA[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillDimArrayB(int[,] arrayB)
{
    for (int i = 0; i < arrayB.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            arrayB[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintDimArrayB(int[,] arrayB)
{
    for (int i = 0; i < arrayB.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            Console.Write($"{arrayB[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillDimArrayC(int[,] arrayC)
{
    if (twoDimArrayA.GetLength(0) != twoDimArrayB.GetLength(1))
    {
        Console.WriteLine("Введите одинаковое количество строк и столбцов! ");
        return;
    }

    for (int i = 0; i < twoDimArrayA.GetLength(0); i++)
    {
        for (int j = 0; j < twoDimArrayB.GetLength(1); j++)
        {
            twoDimArrayC[i, j] = 0;
            for (int k = 0; k < twoDimArrayA.GetLength(1); k++)
            {
                twoDimArrayC[i, j] = twoDimArrayA[i, k] * twoDimArrayB[j, k];
            }
        }
    }
}

void PrintDimArrayC(int[,] arrayC)
{
    for (int i = 0; i < arrayC.GetLength(0); i++)
    {
        for (int j = 0; j < arrayC.GetLength(1); j++)
        {
            Console.Write($"{arrayC[i, j]} ");
        }
        Console.WriteLine();
    }
}
