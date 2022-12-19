//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//Считываем данные с консоли
string? firstLine = Console.ReadLine();
string? secondLine = Console.ReadLine();
string? thirdLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (firstLine != null && secondLine != null)
{
    //Парсим введеное число
    int firstNumber = int.Parse(firstLine);
    int secondNumber = int.Parse(secondLine);
    int thirdNumber = int.Parse(thirdLine);

    //Сравниваем три числа и выводим результат
    if (firstNumber > secondNumber)
    {
        if (firstNumber > thirdNumber)
        {
            Console.WriteLine("Максимальное число: " + firstNumber);
        }
        else
        {
            Console.WriteLine("Максимальное число: " + thirdNumber);
        }
    }
    else
    {
        if (secondNumber > thirdNumber)
        {
            Console.WriteLine("Максимальное число: " + secondNumber);
        }
        else
        {
            Console.WriteLine("Максимальное число: " + thirdNumber);
        }
    }
}
