//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (inputLine != null)
{
    //Парсим введеное число
    int inputNumber = int.Parse(inputLine);

    //Вводим новые переменные
    int startNumber = 2;
    string result = string.Empty;

    while (startNumber <= inputNumber)
    {
        result = result + startNumber;
        startNumber = startNumber + 2;
    }

    Console.WriteLine(result);
    
}