// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Введите первое число ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число ");
int c = int.Parse(Console.ReadLine()!);
if (a > b && a > c) Console.WriteLine($"Максимальное первое число={a}");
else if (b > a && b > c) Console.WriteLine($"Максимальное второе число={b}");
else if (c > a && c > b) Console.WriteLine($"Максимальное третье число={c}");
else if (a == b && a == c && b == c) Console.WriteLine("Введенные максимальные числа равны");