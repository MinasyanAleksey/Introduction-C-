//ЗАДАЧА 1 - Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int FindSecondNumber(int number)
{
    int left = number / 10;
    //int right = number % 10;

    int result = left % 10;

    return result;
}

int randNumber = new Random().Next(100,1000);
int metod = FindSecondNumber(randNumber);
Console.WriteLine($"Случайное трехзначное число - {randNumber}");
Console.WriteLine($"Результат задачи - {metod}");