int m = InputNumbers("Введите количество строк m ");
int n = InputNumbers("Введите количество столбцов n ");
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
for (int i = 0; i < n; i++)
{
    double average = 0;
    for (int j = 0; j < m; j++)
    {
        average += matrix[j, i];
    }
    average = Math.Round(average / m, 1);
    Console.WriteLine($"Cреднее арифметическое столбца {i + 1}: {average}");
}