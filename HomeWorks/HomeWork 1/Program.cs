﻿/*int a = 5;
int b = 7;

Console.WriteLine($"Даны два числа: {a} и {b}");*/

//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{
    Console.WriteLine($"Число {number1} больше числа {number2}");
}
else
{
    Console.WriteLine($"Число {number1} меньше числа {number2}");
}