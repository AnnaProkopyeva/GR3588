﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

int X1 = ReadData("Введите координату x1: ");
int Y1 = ReadData("Введите координату y1: ");
int Z1 = ReadData("Введите координату z1: ");
int X2 = ReadData("Введите координату x2: ");
int Y2 = ReadData("Введите координату y2: ");
int Z2 = ReadData("Введите координату z2: ");

double result = CalculateLenght(X1, X2, Y1, Y2, Z1, Z2);

PrintData("Расстояние между точками: ", result);

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод находит расстояние между точками на плоскости
double CalculateLenght(double x1, double y1, double x2, double y2, double z1, double z2)
{
    double distance = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1-z2), 2));
    return distance;
}

//Метод выводит данные пользователю
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

