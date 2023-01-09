
Console.WriteLine("Ввести трёхзначное число");

int N = Convert.ToInt32(Console.ReadLine());

int Metod2(int N)
{
    return N % 100 / 10;
}
int N2 = Metod2(N);

Console.WriteLine($"{N2}");