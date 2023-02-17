// Показать кубы чисел, заканчивающихся на четную цифру

Console.Clear();
Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine()!);
int cub = 1;
int a = 1;

while (a < num)
{
    cub = a * a * a;
    if (cub % 2 == 0)
    {
        Console.Write($"{cub}");
    }
    
    a++;
}
Console.WriteLine($"={cub}");