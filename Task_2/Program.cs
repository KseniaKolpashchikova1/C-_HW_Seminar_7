/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

using System;
using static System.Console;
Clear();

Write("Введите размер матрицы через пробел: ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int m = int.Parse(sizeS[0]);
int n = int.Parse(sizeS[1]);
int[,] array =GetRandomArray(m, n);

Write("Введите номер позицию элемента строки массива: ");
int position1 = Convert.ToInt32(Console.ReadLine()) -1;
Write("Введите номер позиции элемента столбца массива: ");
int position2 = Convert.ToInt32(Console.ReadLine()) -1;
int[,] numbers = new int[10, 10];
PrintArray (array);

int[,] GetRandomArray(int row, int column)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(-10, 10);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

if (position1>array.GetLength(0) || position2> array.GetLength(1))
            {
                Write("Данного элемента нет в массиве!");
            }
            else WriteLine($"Значение заданного элемента строки и столбца: {array[position1, position2]}");
            