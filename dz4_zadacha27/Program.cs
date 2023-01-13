Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int number)
{
    int counter = Convert.ToString(number).Length;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        result = result + (number - (number - number % 10));
        number = number / 10;
    }
    return result;
}
int sumNumber = SumNumber(number);
Console.WriteLine(sumNumber);