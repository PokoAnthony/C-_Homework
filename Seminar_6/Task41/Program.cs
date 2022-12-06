// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.Write("Введите M чисел (через запятую): ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse); // Array.ConvertAll метод преобразования массива одного типа в другой тип, Split -  разбивает входную строку по одному или нескольким разделителям 
int sum = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sum++;
    }
}
 
Console.WriteLine($"Количество чисел M больше '0' = {sum}");
    
      