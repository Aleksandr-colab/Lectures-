// Написать программу вычисления произведения чисел от 1 до N

Console.Clear();
Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine()!);
int count = 1;
int a = 1;

while (a <= num)
{
    count = count * a;
    Console.Write($"{a}");
    a++;
}
Console.WriteLine($"={count}");