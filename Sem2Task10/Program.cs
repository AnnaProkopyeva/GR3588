//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число:");
int inputNumber = int.Parse(Console.ReadLine() ?? "0");

if (inputNumber < 1000 && inputNumber > 99)
{
    Console.WriteLine((inputNumber / 10) % 10);
}
else
{
    Console.WriteLine("Введено неверное число!");
}