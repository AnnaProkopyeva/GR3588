// ---------------------------------------------------------------------------------
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// ---------------------------------------------------------------------------------

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

// Метод суммирования заданного числа
int SumDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

int number = ReadData("Введите число: ");

int sumNumber = SumDigit(number);

PrintData("Сумма чисел " + number + " = " + sumNumber);


