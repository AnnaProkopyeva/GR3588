//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//Считываем данные с консоли
string? firstLine = Console.ReadLine();
string? secondLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (firstLine != null && secondLine != null)
{

    //Парсим введеное число
    int firstNumber = int.Parse(firstLine);
    int secondNumber = int.Parse(secondLine);

    //Сравниваем два числа и выводим результат
    if (firstNumber > secondNumber)
    {
        Console.WriteLine("Первое число больше второго!");
    }
    else
    {
        Console.WriteLine("Второе число больше первого!");
    }
}