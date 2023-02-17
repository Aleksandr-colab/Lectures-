// Подсчитать сумму цифр в числе
Console.Clear();
Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine()!);
int num1 = num % 10;
int sum = 0;

while (num / 10 != 0)
{
    num = num / 10;
    sum = sum + num % 10;
}
Console.WriteLine(sum + num1);