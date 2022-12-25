// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int inputNumber = ReadData("Введите число: ");
bool result = PalinTest(inputNumber);
PrintData(result);

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод проверки числа на полиндромность
bool PalinTest(int inputNumber)
{
    bool result = false;
    result = (inputNumber / 10000 == inputNumber % 10) && ((inputNumber / 1000) % 10 == (inputNumber / 10) % 10);
    return result;
}

//Метод вывода данных
void PrintData(bool result)
{
    Console.WriteLine(result);
}