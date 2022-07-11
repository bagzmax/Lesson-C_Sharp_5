// Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
Console.Clear();
int[] array = new int[4] {-4, -8, 8, 2};
GetSignArray(array);
Console.WriteLine($"[{String.Join(",", array)}]");

void GetSignArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
    {
    array[i] *= -1;
    }
}