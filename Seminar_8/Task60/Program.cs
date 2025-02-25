﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
int[,,] arraythreeDim = new int[2, 2, 2];
FillArray(arraythreeDim);
PrintIndex(arraythreeDim);
Console.WriteLine();

void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < arraythreeDim.GetLength(0); i++)
    {
        for (int j = 0; j < arraythreeDim.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < arraythreeDim.GetLength(2); k++)
            {
                Console.Write($"{arraythreeDim[i, j, k]} ({i}, {j}, {k}) ");
            }
        }
    }
}

void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}
