// --------------------------------------------------------------------
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// --------------------------------------------------------------------

int number1 = ReadData("Введите число M: ");
int number2 = ReadData("Введите число N: ");
long result = AkkermanRec(number1, number2);
Console.Write("Результат: ");
PrintResult(result);

// Метод ввода данных от пользователя.
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод печати данных.
void PrintResult(long prefix)
{
    Console.WriteLine(prefix);
}

// Метод вычесления функции Аккермана
int AkkermanRec(int M, int N)
{
    if (M == 0) return N + 1;
    else
    {
        if (N == 0 && M > 0) return AkkermanRec(M - 1, 1);
        else return AkkermanRec(M - 1, AkkermanRec(M, N - 1));
    }
}