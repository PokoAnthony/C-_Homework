// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


Console.Clear();

int[] FillIntArray(int[] arrayNumbers) // Функция заполнение целых чисел массива
{
    for (int i = 0; i < arrayNumbers.Length; i++)
    {
        arrayNumbers[i] = new Random().Next(100, 1000);
    }
    return arrayNumbers;
}

void PrintIntArray(int[] arrayElements) // Функция вывода целых чисел массива
{
    for (int i = 0; i < arrayElements.Length; i++)
    {
        Console.Write($"{arrayElements[i]} ");
    }
    Console.WriteLine();
}

int EvenNumbers(int[] arrayNums) // Функция вычисления чётных чисел
{
    int n = 0;
    for (int i = 0; i < arrayNums.Length; i++)
    {
        if (arrayNums[i] % 2 == 0)
        {
            n++;
        }
    }
    return n;
}

int SumElements(int[] odd) // Функция вычисления суммы элементов, стоящих на нечётных позициях
{
    int sum = 0;
    for (int i = 0; i < odd.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += odd[i];
        }
    }
    return sum;
}


double[] FillDoubleArray(double[] arrayNumbers) // Функция заполнение вещественных чисел массива
{
    for (int i = 0; i < arrayNumbers.Length; i++)
    {
        double numbers = new Random().Next(0, 100) + new Random().NextDouble();
        arrayNumbers[i] = Math.Round(numbers, 1);
    }
    return arrayNumbers;
}

void PrintDoubleArray(double[] arrayElements) // Функция вывода вещественных чисел массива
{
    for (int i = 0; i < arrayElements.Length; i++)
    {
        Console.Write($"{arrayElements[i]} ");
    }
    Console.WriteLine();
}

double DiffMaxMin(double[] arrayNumbers) // Функция вычисления разницы между максимальным и минимальным элементов массива
{
    double max = arrayNumbers[0];
    double min = arrayNumbers[0];
    double diff = 0;
    for (int i = 0; i < arrayNumbers.Length; i++)
    {
        if (arrayNumbers[i] > max) max = arrayNumbers[i];
        if (arrayNumbers[i] < min) min = arrayNumbers[i];
    }
    diff = max - min;
    return diff;
}



Console.Write("Введите количество элементов в массиве Задачи № 34: ");
int[] array1 = new int[int.Parse(Console.ReadLine())];

array1 = FillIntArray(array1);
PrintIntArray(array1);

Console.WriteLine("Количество чётных чисел в массиве = {0}", EvenNumbers(array1));
Console.WriteLine();
Console.WriteLine();


Console.Write("Введите количество элементов в массиве Задачи № 36: ");
int[] array2 = new int[int.Parse(Console.ReadLine())];

array2 = FillIntArray(array2);
PrintIntArray(array2);

Console.WriteLine("Сумма элементов на нечётных позициях в массиве = {0}", SumElements(array2));
Console.WriteLine();
Console.WriteLine();


Console.Write("Введите количество элементов в массиве Задачи № 38: ");
double[] array3 = new double[int.Parse(Console.ReadLine())];

array3 = FillDoubleArray(array3);
PrintDoubleArray(array3);
double maxMin = Math.Round(DiffMaxMin(array3), 1);
Console.WriteLine("Разница между максимальным и минимальным элементов массива = {0}", maxMin);
