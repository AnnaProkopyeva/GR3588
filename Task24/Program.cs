// ------------------------------------------------
// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А
// -------------------------------------------------


//запрос данных у пользователя
int ReadData(string line)
{
    //выводим сообщение
    Console.Write(line);
    //считываем число
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP; //возвращаем значение
}

// Метод вывода результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Метод простого сложения всех чисел
int VariantSumSimple(int numA)
{
    int sumOfNumbers = 0;
    for (int i = 1; i <= numA; i++)
    {
        sumOfNumbers += i;
    }
    return sumOfNumbers;
}

// Метод расчета по методу Гаусса
int VariantSumGause(int numA)
{
    int sumOfNumbers = 0;
    sumOfNumbers = ((1 + numA) * numA) / 2;
    return sumOfNumbers;
}

int numberA = ReadData("Введите число А: ");

// Смотрим, сколько займет времени первый метод
DateTime d1 = DateTime.Now;
int res1 = VariantSumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

// Смотрим, сколько займет времени второй метод
DateTime d2 = DateTime.Now;
int res2 = VariantSumGause(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Сумма чисел от 1 до A равна(простой метод): " + res1);
PrintResult("Сумма чисел от 1 до A равна(простой Гауса): " + res2);