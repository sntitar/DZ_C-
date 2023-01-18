Console.Write("Введите m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n ");
int n = Convert.ToInt32(Console.ReadLine());


double[,] array = new double[m, n];

void FillArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 10;
        }
    }
}

void WriteArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double alignNumber = Math.Round(array[i, j], 1);
            Console.Write(alignNumber + " ");
        }
        Console.WriteLine();
    }
}

FillArray(array);
WriteArray(array);