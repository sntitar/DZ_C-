int[] array = {3, 4, -9, 1};
int N = array.Length;
int index = 0;
int max = 0;

while (index < N)
    if (array[index] > max)
        max = array[index];
    else
        index++;

Console.WriteLine(max);
