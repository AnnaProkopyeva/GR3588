// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = GenArray(50, 100, 999);
Console.WriteLine("Сгенерированный массив: ");
PrintArray(array);
Console.WriteLine();
int result = CountEven(array);
PrintData("Количество четных чисел в массиве: ", result);

// Метод генерирующий случайный массив
int[] GenArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

// Метод вывода сгенерированного массива
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

// Метод вывода данных
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

// Метод вычисляющий количество четных чисел в массиве
int CountEven(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            res++;
        }
    }
    return res;
}
