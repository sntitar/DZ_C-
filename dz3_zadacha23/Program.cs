void Cube(int[] cube)
{
    int counter = 0;
    int length = cube.Length;
    while (counter < length)
    {
        cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
        counter++;
    }
}

void Print(int[] array)
{
    int count = array.Length;
    int index = 1;
    while (index < count)
    {
        Console.Write(array[index] + " ");
        index++;
    }
}

Console.Write("Введите число ");
int cube = Convert.ToInt32(Console.ReadLine());

int[] array = new int[cube + 1];
Cube(array);
Print(array);

