﻿Console.Write("Введите количество строк m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[m, n];
void FillArray(double[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
}
void PrintArray(double[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double number = Math.Round(matrix[i, j], 1);
            Console.Write(number + "  ");
        }
        Console.WriteLine();
    }
}
FillArray(matrix);
PrintArray(matrix);