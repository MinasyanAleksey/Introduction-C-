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
MinSumElements(newArray);