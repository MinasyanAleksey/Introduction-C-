//-----------------------------------------
// ----------- ДОМАШНЯЯ РАБОТА 7 ----------
//-----------------------------------------

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*double [,] CreateRandome2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество столбцов: ");
    int colums = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите минимально возможное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите максимально возможное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] newArray = new double[rows, colums];
    Random rand = new Random ();

    for(int i = 0; i < rows; i++)
    {   for(int j = 0; j < colums; j++)
        {
            newArray[i,j] = Math.Round((rand.NextDouble() + rand.Next(minValue, maxValue + 1)), 2);
        }
    }       
    return newArray;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }

    Console.WriteLine();
}

double[,] newArray = CreateRandome2dArray();
Show2dArray(newArray);*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*int [,] CreateRandome2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество столбцов: ");
    int colums = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите минимально возможное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите максимально возможное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, colums];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            newArray[i,j] = new Random().Next(minValue,maxValue +1);
    
    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }

    Console.WriteLine();
}

int[,] newArray = CreateRandome2dArray();
Show2dArray(newArray);

Console.Write("Введите индекс строки: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс столбца: ");
int colum = Convert.ToInt32(Console.ReadLine());

if (row > newArray.GetLength(0) || colum > newArray.GetLength(1))
    Console.WriteLine("Такого элемента нет");
else
    Console.WriteLine($"Значение элемента {row} строки и {colum} столбца равно {newArray[row,colum]}");*/


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] CreateRandome2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество столбцов: ");
    int colums = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите минимально возможное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите максимально возможное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, colums];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            newArray[i,j] = new Random().Next(minValue,maxValue +1);
    
    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }

    Console.WriteLine();
}

void SumElementsEachColumn(int[,] array)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        int n = array.GetLength(1);
        double average = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            average += array[i,j];
        }

        average /= n;
        Console.WriteLine($"Среднее арифметическое по {j} столбцу:  {average};");
        //Console.Write(average + "; ");
    }

    Console.WriteLine();
}

int[,] newArray = CreateRandome2dArray();
Show2dArray(newArray);
SumElementsEachColumn(newArray);