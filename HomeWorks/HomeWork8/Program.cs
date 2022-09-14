//-----------------------------------------
// ----------- ДОМАШНЯЯ РАБОТА 8 ----------
//-----------------------------------------

//-----Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void SortArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if(array[i, k] < array[i, k + 1])
                {
                    int temp = 0;
                    temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                    
                }
            }
        }
    }
}

int[,] newArray = CreateRandome2dArray();
Show2dArray(newArray);
SortArray(newArray);
Show2dArray(newArray);*/


//-----Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int SumLineElements(int[,] array, int i)  //--------Суммируем строки массива и выводим в консоль для наглядности
{
    int sumLine = 0;
    
    for(int j = 0; j < array.GetLength(1); j++)
    {
        sumLine += array[i,j];
    }
    Console.WriteLine($"Сумма элементов по {i} строке:  {sumLine};");
      
    return sumLine;
}

void MinSumElements(int[,] array)        //--------Из найденных сумм создаем массив, находим наименьшую сумму и выводим в консоль индекс строки с наименьшей суммой
{
    int minSumLine = 0;
    int sumLine = SumLineElements(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSumLine = SumLineElements(array, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }
    }

    Console.WriteLine($"\n{minSumLine} - строкa с наименьшей суммой ({sumLine}) элементов ");
}


int[,] newArray = CreateRandome2dArray();
Show2dArray(newArray);
MinSumElements(newArray);*/


//-----Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MultiplicationMatrix(int[,] array, int[,] array1)
{
    int rows = array1.GetLength(0);
    int colums = array.GetLength(1);
    int[,] newArray = new int[rows, colums];
    if(rows != colums) Console.WriteLine("Данные матрицы умножать нельзя!");
    else
        
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < colums; j++)
            {
                int sum = 0;
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    sum += array[i,k] * array1[k,j];
                }
                newArray[i,j] = sum;
            }
        }
        return newArray;
}

Console.WriteLine("Заполнение первой матрицы: ");
int[,] newArray1 = CreateRandome2dArray();
Console.WriteLine("\nЗаполнение второй матрицы: ");
int[,] newArray2 = CreateRandome2dArray();
Show2dArray(newArray1);
Show2dArray(newArray2);

Console.WriteLine("\nРезультат умножения двух матриц: ");
int[,] newArray3 = MultiplicationMatrix(newArray1, newArray2);
Show2dArray(newArray3);*/


//-----Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int [,,] CreateRandome3dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество столбцов: ");
    int colums = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество колонок: ");
    int colums1 = Convert.ToInt32(Console.ReadLine());

    int[,,] newArray = new int[rows, colums, colums1];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            for(int k = 0; k < colums1; k++)
                newArray[i,j,k] = GenerateUniqueNumber();
    
    return newArray;
}

void Show3dArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {   for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"[{i},{j},{k}] - {array[i,j,k]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

HashSet<int> numbers = new HashSet<int>(); //---Создание динамической неупорядоченной коллекции
Random rand = new Random();

int GenerateUniqueNumber()
{
    while (true)
    {
        var n = rand.Next(10, 100); //---Генерируем случайный уникальный номер из заданного диапазона
        if (!numbers.Contains(n))  //---Проверяем на неповторяемость
        {
            numbers.Add(n); //--Добавляем в коллецию
            return n;
        }
    }
}

int[,,] newArray = CreateRandome3dArray();
Show3dArray(newArray);