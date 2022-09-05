//-----------------------------------------
// ----------- ДОМАШНЯЯ РАБОТА 6 ----------
//-----------------------------------------

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*int[] CreateMyArray(int size)
{
    int[] newArray = new int[size];
    
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i+1} число: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void ShowNumber(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] >0) result++;
    Console.Write($"Пользователь ввел {result} чисел больше 0: ");
}

Console.Write("Сколько чисел вы хотите ввести: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateMyArray(size);
ShowArray(myArray);
Console.WriteLine();
ShowNumber(myArray);*/


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void FindPoint(double a, double c, double b, double d)
{
    // for(int i = 0; i < array.Length; i++)
    //     Console.Write(array[i] + " ");
    // Console.WriteLine();
    double x = (d-c) / (a-b);
    double y = a * x + c;
    if(a == b)
        Console.Write("Прямые параллельны");
    else
        Console.Write($"Точка пересечения двух прямых: x: {x}, y: {y}");
}

Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

FindPoint(k1, b1, k2, b2);