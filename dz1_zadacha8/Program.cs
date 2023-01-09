int[] array = {1, 4, 7, 8, 9, };
int N = array.Length;
int index = 0;

while (index < N)
{
    if (array[index] % 2 == 0)
    {
        Console.WriteLine(array[index]);
    }
    
    index++;
}