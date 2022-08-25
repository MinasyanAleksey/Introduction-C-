//ДОМАШНЕЕ ЗАДАНИЕ №3

//Задача 19 - Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// ------ВАРИАНТ 1------ Четко по условию задачи!

/*void Polindrom(int num)
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

Polindrom(number);*/


// ------ВАРИАНТ 2------ Работает с любыми числами до 10 символов

void Polindrom(int num)
{
    string numberText = Convert.ToString(num);
    int length = numberText.Length;
    
    int current = num;
    int result = 0;
    int i = Convert.ToInt32(Math.Pow(10, length));
    
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

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Polindrom(number);