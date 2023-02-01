// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Введите первое число ");
int num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число ");
int num_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число ");
int num_3 = int.Parse(Console.ReadLine()!);
if (num_1 > num_2) 
{
   if (num_1 > num_3)
   {
        Console.WriteLine($"максимальное число: {num_1}");
   }
    else
    {
        Console.WriteLine($"максимальное число: {num_3}");
    }
}
else if (num_2 > num_3)
{
    Console.WriteLine($"максимальное число: {num_2}");
}
else
{
    Console.WriteLine($"максимальное число: {num_3}");
}

