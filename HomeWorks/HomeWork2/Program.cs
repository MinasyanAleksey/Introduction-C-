﻿//ЗАДАЧА 1 - Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*int FindSecondNumber(int number)
{
    int left = number / 10;
    //int right = number % 10;

    int result = left % 10;

    return result;
}

int randNumber = new Random().Next(100,1000);
int metod = FindSecondNumber(randNumber);
Console.WriteLine($"Случайное трехзначное число - {randNumber}");
Console.WriteLine($"Результат задачи - {metod}");*/


//ЗАДАЧА 2 - Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

void ThirdDigit(int number)
{
    string numberText = Convert.ToString(number);

    if (numberText.Length > 2)
        Console.WriteLine("Третья цифра - " + numberText[2]);
    else
        Console.WriteLine("Третьей цифры нет");
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

ThirdDigit(num);