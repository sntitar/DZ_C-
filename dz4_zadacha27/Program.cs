// Создание

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

// Суммирование чисел
int SumNumber(int number)
{
    int count = Convert.ToString(number).Length;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
        result = result + (number - (number - number % 10));
        number = number / 10;
    }
    return result;
}

// Вывод суммы
int sumNumber = SumNumber(number);
Console.WriteLine(sumNumber);