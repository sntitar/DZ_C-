int m = InputNumbers("Введите неотрицательное число M: ");
int n = InputNumbers("Введите неотрицательное число N: ");
Console.WriteLine($"A ({m}, {n}) = {numberA(m, n)}");
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
int numberA(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return numberA(m - 1, 1);
    else
        return numberA(m - 1, numberA(m, n - 1));
}