//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число:");
int inputNumber = int.Parse(Console.ReadLine() ?? "0");

if (inputNumber > 0 && inputNumber < 8)
{
    if (inputNumber > 5)
    {
        Console.WriteLine("Расслабься, сегодня выходной!");
    }
    else
    {
        Console.WriteLine("Сегодня рабочий день!");
    }
}
else
{
    Console.WriteLine("Введено недопустимое число!");
}

