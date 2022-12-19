//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (inputLine != null)
{
    //Парсим введеное число
    int inputNumber = int.Parse(inputLine);

    //Находим квадрат числа
    //Способ №1
    //int outNumber = inputNumber * inputNumber;
    //Способ №2 (встроенная формула)
    //int outNumber = (int)Math.Pow(inputNumber, 2); 

    //Выводим данные в консоль
    //Для способа №1 и №2
    //Console.WriteLine(outNumber);
    Console.WriteLine(Math.Pow(int.Parse(inputLine), 2)); //(Способ №3, используется без нахождения квадрата)
}
