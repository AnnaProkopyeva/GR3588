﻿// Задайте одномерный массив из 123 случайных
// чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99]

int[] array = GenArray(123, -100, 100);
PrintArray(array);
int result = CountElement(array, 10, 99);
Console.WriteLine();
PrintData("Количество элементов массива, значения которых лежат в отрезке [10,99] составляет: ", result);

// Метод генерации массива
int[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] outArray = new int[len];
    for (int i = 0; i < len; i++)
    {
        outArray[i] = new Random().Next(minValue, maxValue);
    }
    return outArray;
}

// Метод вывода результата
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

// Метод печати сгенерированного массива
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

// Метод подсчета количества элементов массива
int CountElement(int[] array, int min, int max)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > min && array[i] < max)
        {
            res++;
        }
    }
    return res;
}