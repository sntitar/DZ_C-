int[] CreateArray()
{
    int number = Random.Shared.Next(2, 20);
    int[] array = new int[number];
    return array;

}
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(2, 20);
    }
}
string PrintArray(int[] printArray)
{
    string output = string.Empty;
    int size = printArray.Length;
    for (int i = 0; i < size; i++)
    {
        output = output + $"{printArray[i]} ";
    }
    return output;
}

int[] newArray(int[] multi)
{
    int[] newArray = new int[multi.Length / 2];
    for (int i = 0; i < multi.Length / 2; i++)
    {
        newArray[i] = multi[i] * multi[multi.Length - i - 1];
    }
    return newArray;
}
int[] array = CreateArray();
FillArray(array);
string Print = PrintArray(array);
Console.WriteLine(Print);
int[] newArr = newArray(array);
string newPrint = PrintArray(newArr);
Console.WriteLine(newPrint);
