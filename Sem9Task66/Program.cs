// ---------------------------------------------------------------------------------------
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// ---------------------------------------------------------------------------------------

int number1 = ReadData("Введите число M: ");
int number2 = ReadData("Введите число N: ");
int result = number1 < number2 ? SumMNRec(number1, number2) : SumMNRec(number2, number1);
Console.Write("Сумма натуральных элементов в промежутке от M до N равна: ");
PrintResult(result.ToString());

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

// Метод вычесления суммы натуральных числе от M до N.
int SumMNRec(int M, int N)
{
    if (M >= N) return N;
    return M + SumMNRec(M + 1, N);
}