// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество двухзначных элементов массива.
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();

int size = 123;
int count = 0;
int[] array = new int[size];
GetArray(array);

for (int i = 0; i < array.Length; i++)
{
    /* if (array[i] >= 10 && array[i] <= 99)
    {
        count += 1;
    } */
    count += (array[i] >= 10 && array[i] <= 99) ? 1 : 0;
}

Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine(count);

int[] GetArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(200);
    }
    return array;
}