// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

Console.Clear();

Console.WriteLine("Введите координаты x1 и y1:");
int x1 = int.Parse(Console.ReadLine()!), y1 = int.Parse(Console.ReadLine()!);;

Console.WriteLine("Введите координаты x2 и y2:");
int x2 = int.Parse(Console.ReadLine()!), y2 = int.Parse(Console.ReadLine()!);;

double res = Math.Round(Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2)), 2);

Console.WriteLine($"Расстояние между точками: {res}");