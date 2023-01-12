// ----------------------------------------------------------------------------------
// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// ----------------------------------------------------------------------------------

int number = ReadData("Введите число N: ");
string resultLine = LineGenRec(number);
Console.Write("Натуральные числа от " + number + " до 1: ");
PrintResult(resultLine);

// Метод ввода данных от пользователя.
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод печати данных.
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

// Метод определения натуральных чисел от N до 1.
string LineGenRec(int num)
{
    if (num <= 0)
    {
        return string.Empty;
    }
    else
    {
        string outLine = num + " " + LineGenRec(num - 1);
        return outLine;
    }
}
