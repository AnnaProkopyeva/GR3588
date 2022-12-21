//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа

//Вариант №1
// System.Random numberSintezator = new System.Random();   // создаем экземпляр класса рандомайзер
// int num = numberSintezator.Next(100,1000);             // получаем случайное число
// Console.WriteLine (num);
// Console.WriteLine((num/100)*10 + num%10);

//Вариант №2
System.Random random = new System.Random();

int randomNumber = random.Next(100, 1000);

Console.WriteLine("число: " + randomNumber);

string value = randomNumber.ToString();

char[] numberArray = value.ToCharArray();

Console.WriteLine(numberArray[0] + "" + numberArray[2]);