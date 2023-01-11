double GetDistance(double xA, double xB, double yA, double yB, double zA, double zB)
{
    return Math.Sqrt(Math.Pow(xB - xA, 2) +
                     Math.Pow(yB - yA, 2) +
                     Math.Pow(zB - zA, 2));
}

double GetValue(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}


double xA = GetValue("xA = ");
double xB = GetValue("xB = ");
double yA = GetValue("yA = ");
double yB = GetValue("yB = ");
double zA = GetValue("zA = ");
double zB = GetValue("zB = ");

double distance = GetDistance(xA, xB, yA, yB, zA, zB);
Console.WriteLine(distance);
