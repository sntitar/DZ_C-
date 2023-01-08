int[] array = { 3, 4, -9, 1, 8, 80 };
int N = array.Length;
int index = 0;

while (index < N)
{
    if (array[index] % 2 == 0)
        Console.WriteLine(array[index]);
index++;
}