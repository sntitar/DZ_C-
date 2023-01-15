Console.Write($"Введите количество чисел ");
int number = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[number];

void InputNumbers(int number)
{
    for (int i = 0; i < number; i++)
    {
        Console.Write($"Введите {i + 1} число ");
        arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}


int CheckingNumber(int[] arrayNumbers)
{
    int count = 0;
    for (int i = 0; i < arrayNumbers.Length; i++)
    {
        if (arrayNumbers[i] > 0) count += 1;
    }
    return count;
}

InputNumbers(number);
Console.WriteLine($"Введено чисел больше нуля {CheckingNumber(arrayNumbers)} ");