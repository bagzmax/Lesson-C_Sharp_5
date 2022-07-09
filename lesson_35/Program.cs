﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество двухзначных элементов массива.
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = {5, 18, 123, 6, 2, 222};
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 9 && array[i] < 199)
    {
        count += 1;
    }
    //count += (array(i) > 9 && array(i) < 100) ? 1 : 0;
}

Console.WriteLine($"[{String.Join(",", array)}]");
System.Console.WriteLine(count);
