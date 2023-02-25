// // Задача 2: Напишите программу, которая на вход принимает два числа и выдает, 
// // какое число большее, а какое меньшее.

// Console.Clear();

// Console.Write("Введите первое число : ");
// int number1 = int.Parse (Console.ReadLine()!);
// Console.Write("Введите второе число : ");
// int number2 = int.Parse (Console.ReadLine()!);

//  if (number1 > number2)
 
// {
//     Console.WriteLine($"Первое число {number1} больше второго числа {number2}");
// } 
//  if (number2 > number1)
  
// {
//     Console.WriteLine($"Второе число {number2} больше первого числа {number1}");
// }

// Напишите программу, которая принимает на вход три числа 
// и выдает максимальное из этих чисел.

// Console.Clear();

// Console.Write("Введите первое число : ");
// int number1 = int.Parse (Console.ReadLine()!);
// Console.Write("Введите второе число : ");
// int number2 = int.Parse (Console.ReadLine()!);
// Console.Write("Введите третье число : ");
// int number3 = int.Parse (Console.ReadLine()!);

// if (number1 > number2)
// {
//     if (number1 > number3)
//     {
//         Console.WriteLine($"Максимальное число {number1} ");
//     }
//      else
//     {   
//         Console.WriteLine($"Максимальное число {number3} ");
//     }
// }
//     else if (number2 > number3) 
//     {
//         Console.WriteLine($"Максимальное число {number2} ");
//     }
//     else
//     {
//         Console.WriteLine($"Максимальное число {number3} ");
//     }



// Напишите программу, которая на вход принимает число и выдает, 
// является ли число четным (делится ли оно на два без остатка).
// Console.Clear();

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine()!);

// if (number % 2 != 0)
// {
//     Console.WriteLine("число не  является четным: ");
// }
// else
// {
//     Console.WriteLine("число  является четным: ");
// }

// Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.

// Console.Clear();

// Console.WriteLine("Введите число: ");
// int numberN = Convert.ToInt32(Console.ReadLine()!);
//  int numberB = 2;
// while (numberB <= numberN)
// {
//     Console.WriteLine($"четные числа до {numberB}");
//     numberB +=2 ;
// }