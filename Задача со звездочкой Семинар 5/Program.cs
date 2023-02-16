// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька.
// Реализовать невозрастающую сторировку.
// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]
Console.Clear();


int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[]array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = 1;

        for (int j = i + 1; j < array.Length ; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[1];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);