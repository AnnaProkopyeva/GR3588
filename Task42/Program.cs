// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

int inputNumber = ReadData("Enter number: ");

PrintData("Result: " + DegToBin(inputNumber));
PrintData("Result: " + DecToBinNativ(inputNumber));
PrintData("Result: " + Convert.ToString(inputNumber, 8));       // перевод в восмеричную систему
PrintData("Result: " + Convert.ToString(inputNumber, 16));      // перевод в шестнадцеричную систему

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

// Метод преобразования десятичного числа в двоичное
string DegToBin(int num)
{
    string outBin = String.Empty;
    while (num > 0)
    {
        outBin = (num % 2) + outBin;
        num = num / 2;
    }
    return outBin;
}

// Встроенные метод преобразования
string DecToBinNativ(int num)
{
    return Convert.ToString(num, 2);
}