//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число:");
int inputNumber = int.Parse(Console.ReadLine() ?? "0");

if (inputNumber > 99)
{
    char[] digits = inputNumber.ToString().ToCharArray();
    Console.WriteLine(digits[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет!");
}