﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1>num2)
{
    Console.WriteLine("Число"+num1+" Максимальное");
}

else if (num2>num3)
{
  Console.WriteLine("Число"+num2+" Максимальное");
}
else if (num3>num1)
{
  Console.WriteLine("Число"+num3+" Максимальное ");
}