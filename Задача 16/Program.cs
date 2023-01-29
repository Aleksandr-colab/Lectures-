// Задача No16. Работа в группах Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.Clear();

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите первое число: ");
int num2 = int.Parse(Console.ReadLine()!);

int a1 = num1 * num1;
int a2 = num2 * num2;
if (a1 == num2 || a2 == num1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}