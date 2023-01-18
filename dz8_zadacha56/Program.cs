int m = InputNumbers("Введите число строк m ");
int n = InputNumbers("Введите число столбцов n ");
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
int minSum = 1;
int sumLine = sumLineNumber(matrix, 0);
int sumLineNumber(int[,] matrix, int i)
{
    int sumLine = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sumLine += matrix[i, j];
    }
    return sumLine;
}
for (int i = 1; i < matrix.GetLength(0); i++)
{
    int minSumLine = sumLineNumber(matrix, i);
    if (sumLine > minSumLine)
    {
        sumLine = minSumLine;
        minSum = i + 1;
    }
}
Console.WriteLine($"Cтрокa с наименьшей суммой элементов: {minSum} ");