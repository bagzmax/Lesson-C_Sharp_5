// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();
int[] array = new int[4] {-4, -8, 8, 2};
/* FindNumberInArrayPrint(array, -4);

void FindNumberInArrayPrint(int[] array, int number)
{
    foreach (var item in array)
    {
        if (item == number)
        {
            System.Console.WriteLine($"Число {number} есть в массиве");
            return; // выход из функции            
        }
    }
    System.Console.WriteLine($"Число {number} нет в массиве");
} */

int searchNumber = -8;
bool flagResult = false;
for (int i = 0; i<array.Length; i++)
{
    if (searchNumber == array[i])
    {
        flagResult = true;
        break;
    }
}

if (flagResult) Console.WriteLine($"Элемент {searchNumber} найден");
else Console.WriteLine($"Элемент {searchNumber} НЕ найден");