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

/*void Polindrom(int num)
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

Polindrom(number);*/


// ------ВАРИАНТ 3------ Работает с любыми числами

/*void Polindrom(long num)
{
    string numberText = Convert.ToString(num);
    long length = numberText.Length;
    
    long current = num;
    long result = 0;
    long i = Convert.ToInt64(Math.Pow(10, length));
    
    while (num > 0)
    {
        long a = num % 10;
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
long number = Convert.ToInt64(Console.ReadLine());

Polindrom(number);*/


// Задача 21 - Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double n1 = x2 - x1;
    double n2 = y2 - y1;
    double n3 = z2 - z1;
    return Math.Sqrt(n1*n1 + n2*n2 + n3*n3);
}

Console.WriteLine("Введите координаты первой точки (x + enter, y + enter, z + enter):");
double xA = Convert.ToDouble(Console.ReadLine());
double yA = Convert.ToDouble(Console.ReadLine());
double zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки (x + enter, y + enter, z + enter):");
double xB = Convert.ToDouble(Console.ReadLine());
double yB = Convert.ToDouble(Console.ReadLine());
double zB = Convert.ToDouble(Console.ReadLine());

double dist = FindDistance(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Расстояние между точками - {dist}");*/


// Задача 23 - Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void FindCube(int num)
{
    int i = 1;
    Console.Write($"Таблица кубов чисел от 1 до {num} - ");
    while(i <= num)
    {
        if(i == num) 
            Console.Write($"{i*i*i}.");
        else
            Console.Write($"{i*i*i}, ");

        i++;
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

FindCube(number);