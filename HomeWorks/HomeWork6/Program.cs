//-----------------------------------------
// ----------- ДОМАШНЯЯ РАБОТА 6 ----------
//-----------------------------------------

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] CreateMyArray(int size)
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
ShowNumber(myArray);