//ДОМАШНЕЕ ЗАДАНИЕ №3

//Задача 19 - Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// ------ВАРИАНТ 1------

void Polindrom(int num)
{
    int current = num;
    int result = 0;
    int i = 100000;

    while (num > 0)
    {
        int a = num % 10;
        num = num / 10;
        result = result + a * (i / 10);
        i = i / 10;
    }
    
    if(current == result)
        Console.WriteLine($"Число {current} - является палиндромом");
    else
        Console.WriteLine($"Число {current} - не является палиндромом");

}

Console.Write("Введите любое пятизначое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Polindrom(number);