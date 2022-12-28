// -------------------------------------------------
// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.
// -------------------------------------------------


using System.Numerics;

// Метод ввода данных от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода данных
void PrintData(string res)
{
    Console.WriteLine(res);
}

BigInteger CalcFactor(int num)
{
    BigInteger count = 1;
    for (int i = 1; i <= num; i++)
    {
        count *= i;
    }
    return count;
}

int number = ReadData("Введите число А: ");

BigInteger length = CalcFactor(number);

PrintData("Факториал равно: " + length);
