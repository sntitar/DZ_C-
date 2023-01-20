int m = InputNumbers("Введите m ");
int n = InputNumbers("Введите n ");
Console.WriteLine($"Сумма элементов: {sumNumber(m, n)}");
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
int sumNumber(int m, int n)
{
    if (m == n)
        return n;
    return n + sumNumber(m, n - 1);
}