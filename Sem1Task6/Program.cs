//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (inputLine != null)
{
    //Парсим введеное число
    int inputNumber = int.Parse(inputLine);

    //Вводим переменную, которая будет записывать результат деления
    int modulo = inputNumber % 2;

    if (modulo == 0)
    {
        Console.WriteLine("Число четное");
    }
    else
    {
        Console.WriteLine("Число нечетное");
    }
}
