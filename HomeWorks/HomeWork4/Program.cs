// ДОМАШНЕЕ ЗАДАНИЕ 4

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*void FindLevel(int num1, int num2)
{
    int res = 1;
    for(int current = 1; current <= num2; current++)
        res = res * num1;
    
    Console.WriteLine($"Число {num1} в натуральной степени {num2} = {res}");
}

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

FindLevel(number1, number2);*/


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void SumOfNumbers(int num)
{
    int n = num;
    int sum = 0;
    
    while(num > 0)
    {
        sum = sum + num % 10;
        num /= 10;
    }

    Console.WriteLine($"Сумма цифр числа {n} = {sum}");
    
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

SumOfNumbers(number);