// // Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
Console.Clear();
string Recursiv(int N, int M)
{
    if (N == M) return N.ToString();
    else
    {
        return Recursiv(N - 1, M) +", "+ N.ToString();
    }
}

Console.WriteLine("Введите начальное число");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конечное число");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(Recursiv(N, M));