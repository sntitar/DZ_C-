int n = InputNumbers("Введите натуральное число ");
int m = 1;
Console.WriteLine(number(n, m));
int number(int n, int m)
{
    if (n == m) return n;
    else
        Console.Write($"{number(n, m + 1)}, ");
    return m;
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}