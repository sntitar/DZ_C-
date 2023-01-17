(double, double) dataPoint(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return (x, y);
}
double Decision(string text)
{
    System.Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}
double k1 = Decision("k1 = ");
double b1 = Decision("b1 = ");
double k2 = Decision("k2 = ");
double b2 = Decision("b2 = ");
var r = dataPoint(k1, b1, k2, b2);
if (k1 == k2 && b1 == b2)
{
    Console.Write($"Прямые совпадают");
}
else if (k1 == k2 && b1 != b2)
{
    Console.Write($"Прямые параллельны");
}
else
{
    System.Console.WriteLine(r);
}
