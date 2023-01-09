
Console.Write("Введите цифру, обозначающую день недели ");

int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("да");
    }

    else Console.WriteLine("нет");
}

CheckingTheDayOfTheWeek(dayNumber);