﻿int m = InputNumbers("Введите m ");
int n = InputNumbers("Введите n ");
int[,] array = new int[m, n];

CreateArray(array);
WriteArray(array);
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
}
void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(array, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}
Console.WriteLine($"{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");