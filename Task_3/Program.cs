﻿//Задача 3: Задайте произвольный массив. 
//Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.
void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 0, 10);
    PrintArray(array);
    EndPrint(array, arraySize);
}
void EndPrint(int[] arrEnd, int N)
{
    if (N < 1) return;
    System.Console.Write(arrEnd[N] + " ");
    EndPrint(arrEnd, N - 1);
    
}
void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
        System.Console.Write(arrayForPrint[i] + " ");

    System.Console.WriteLine();
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
        tempArray[i] = rand.Next(minValue, maxValue);

    return tempArray;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine()); 
}
Main();