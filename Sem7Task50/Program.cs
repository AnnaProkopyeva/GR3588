// ------------------------------------------------------------------------------------------
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// ------------------------------------------------------------------------------------------

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] arr2D = Fill2DArray(row, column, 10, 99);
Console.WriteLine("Сгенерированный массив: ");
Print2DArrayColor(arr2D);
Console.WriteLine();
int findRow = ReadData("Введите запрашиваемую строку: ");
int findColumn = ReadData("Введите запрашиваемый столбец: ");
int index = SerachElement(arr2D, findRow - 1, findColumn - 1);
Console.WriteLine();
PrintData("Результат: ", index);

// Метод ввода данных пользователем
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод генерации и заполнение двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

// Метод поиска заданного элемента
int SerachElement(int[,] arr, int findRo, int findCol)
{
    int elem = -1;
    if (findRo < arr.GetLength(0))
    {
        if (findCol < arr.GetLength(1))
        {
            elem = arr[findRo, findCol];
        }
    }
    return elem;
}

// Метод печати цветного двумерного массива
void Print2DArrayColor(int[,] matrix)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// Метод вывода данных
void PrintData(string msg, int result)
{
    Console.WriteLine(msg + result);
}




