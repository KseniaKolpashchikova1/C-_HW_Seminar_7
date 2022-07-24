/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

using System;
using static System.Console;
Clear();

Write("Введите размер матрицы через пробел: ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int m = int.Parse(sizeS[0]);
int n = int.Parse(sizeS[1]);
int[,] array =GetRandomArray(m, n);
PrintArray (array);
AverageArifm (array);

int[,] GetRandomArray(int row, int column)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 11);
        }
    }
    return result;
}

void AverageArifm (int [,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
   {
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[j, i];
    }
    Write($"{sum/array.GetLength(0):F1};");
}
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i,j]} ");
        }
        WriteLine();
    }
}