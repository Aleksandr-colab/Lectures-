// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

if (min > array[i, j])
            {
                min = array[i, j];
                minRow = i;
                minCol = j;
            }
        }
    }
    return new int[] {minRow, minCol};;
}

int[,] DellitArray(int[,] array, int[] minIndexes)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int row = 0;
    int col = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == minIndexes[0]) continue;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j != minIndexes[1])
            {
                result[row, col] =  array[i, j];
                col++;
            }
        }
        col = 0;
        row++;
    }
   return  result;
}

Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array2D = GetArray(row, col, -10, 10);
PrintArray(array2D);
Console.WriteLine();
int[] minIndex = MinElementToArray2D(array2D);
int[,] result = DellitArray(array2D, minIndex);
PrintArray(result);