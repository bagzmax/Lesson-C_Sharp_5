// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }

    return array;
}

int SumNumbersParametric(int[] array, bool findPositiveNumbers = true)
{
    int sum = 0;
    foreach (int elem in array)
    {
        /* if (findPositiveNumbers) //ЕСЛИ МЫ ИЩЕМ положит. числа
        /* {
            sum += elem > 0 ? elem : 0; // тернарный оператор - 
        }
        else
        {
            sum += elem < 0 ? elem : 0;
        }*/
        sum += findPositiveNumbers ? (elem > 0 ? elem : 0) : (elem < 0 ? elem : 0);     
    }
    return sum;
}

//int[] array = {1, 3, -1, -5, 6};

void PrintArray(int[] array)
{
    /* for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write("\b\b"); */
    Console.WriteLine(string.Join(", ", array));
}

int[] array = GetArray(12, -9, 9);
//Console.WriteLine(SumNumbersParametric(array, false));
PrintArray(array);

Console.WriteLine($"Sum pos : {SumNumbersParametric(array)}");
Console.WriteLine($"Sum neg : {SumNumbersParametric(array, false)}");
