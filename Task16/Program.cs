// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

void Test(int inputNumber1, int inputNumber2)
{
    bool result = (inputNumber1 / inputNumber2 == inputNumber2);
    if (result == true) Console.WriteLine(" Число " + inputNumber1 + " является квадратом числа " + inputNumber2);
    else Console.WriteLine(" Число " + inputNumber1 + " не является квадратом числа " + inputNumber2);
}

int number1 = int.Parse(Console.ReadLine() ?? "0");
int number2 = int.Parse(Console.ReadLine() ?? "0");
Test(number1, number2);
Test(number2, number1);

