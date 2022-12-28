// -----------------------------------------------------------------------------------
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// -----------------------------------------------------------------------------------

int arrLen = ReadData("Введите длину массива: ");
int lowerNumber = ReadData("Ввидите нижний диапозон массива: ");
int upperNumber = ReadData("Введите верхний даипозон массива: ");

int[] arr = GenArr(arrLen);

PrintData("Сгененрированный массив: ", arr);

// Метод ввода данных от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода данных
void PrintData(string res, int[] arr)
{
    Console.WriteLine(res);
    PrintArr(arr);
}

// Метод генерации случайного массива
int[] GenArr(int num)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(lowerNumber, upperNumber);
    }
    return arr;
}

// Метод печати случайного массива
void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

