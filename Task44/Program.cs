﻿// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

int number = ReadData("Введите число: ");
PrintData("Числа Фибоначчи: " + FibNum(number));

//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод, выводящий на печать данные пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}

//Метод, вычисляющий числа Фибоначчи
string FibNum(int num)
{
    string outLine = "0 1";
    int first = 0;
    int last = 1;
    int buf = 0;
    for (int i = 2; i < num; i++)
    {
        outLine = outLine + " " + (first + last).ToString();
        buf = last;
        last = first + last;
        first = buf;
    }
    return outLine;
}