// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = GenArray(10, 0, 100);
Console.WriteLine("Сгенерированный массив: ");
PrintArray(array);
Console.WriteLine();
int result = SumOdd(array);
PrintData("Сумма элементов, стоящих на нечётных позициях, равна: ", result);

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
int SumOdd(int[] arr)
{
    int res = 0;
    int index = 1;
    while (index < arr.Length)
    {
        res += arr[index];
        index = index + 2;
    }
    return res;
}
