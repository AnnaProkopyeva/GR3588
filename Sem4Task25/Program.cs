// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

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

// Метод возведения в степень
int Pow(int inputNumber1, int inputNumber2)
{
    int res = 1;
    for (int index = 1; index <= inputNumber2; index++)
    {
        res = res * inputNumber1;
    }
    return res;
}


int inputNumber1 = ReadData("Введите число: ");
int inputNumber2 = ReadData("Введите степень: ");

int outNumber = Pow(inputNumber1, inputNumber2);

PrintData(inputNumber1 + " в степени " + inputNumber2 + " = " + outNumber);
