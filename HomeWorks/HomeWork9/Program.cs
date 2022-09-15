//-----------------------------------------
// ----------- ДОМАШНЯЯ РАБОТА 9 ----------
//-----------------------------------------


//-----Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*int FindSumDigit(int m, int n)  
{
    if(m < n) return FindSumDigit(m+1,n)+m;
    else return m;
}
Console.Write(FindSumDigit(1,10));*/


//-----Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//m = 2, n = 3 -> A(m,n) = 29 - не правильно дан результат, при m = 2, n = 3 -> A(m,n) = 9... а не как в условии 29!!!
                                                        //  при m = 3, n = 2 -> A(m,n) = 29...!!!

int AckermannFunction (int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AckermannFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    return AckermannFunction(m, n);
}

Console.WriteLine(AckermannFunction(3,2));