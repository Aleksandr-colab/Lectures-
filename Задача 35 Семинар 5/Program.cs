// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат вотрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5
Console.Clear();
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}


int CountNumbers(int[] array)
{
    int count = 0;
    foreach(int element in array)
    {
        if (element >= 10 && element <= 99 )
        {
            count++;
        }
    }
    return count;
}

int[] array = GetArray(123, 0, 150);
Console.WriteLine(String.Join(", ", array));
int count = CountNumbers(array);
Console.WriteLine(count);
