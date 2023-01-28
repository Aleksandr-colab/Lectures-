// Задача No1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.// a = 25, b = 5 -> да//a = 2, b = 10 -> нет a = 9, b = -3 -> да a = -3 b = 9 -> нет
Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());
if (b * b == a)
{
    Console.WriteLine($"Является число {b} квадратом второго {a}");
}
else
{
    Console.WriteLine($"Не является число {b} квадратом второго {a}");
}