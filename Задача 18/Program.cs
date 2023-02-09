// Задача No18. 
//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.Write("Введите номер четверти: ");
int four = Convert.ToInt32(Console.ReadLine());
if (four ==1)
{
    Console.Write("X > 0 и Y > 0");
}
else if (four == 2)
{
    Console.Write("X < 0 и Y > 0");
}
else if (four == 3)
{
    Console.Write("X < 0 и Y < 0");
}
else if (four == 4)
{
    Console.Write("X > 0 и Y < 0");
}
else
{
    Console.WriteLine("такой четверти нет");
}
