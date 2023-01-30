string[] array = new string[5] { "Hello", "world", "2", "Denmark", "777" };
string[] arrayNew = new string[array.Length];
void SecondArray(string[] array, string[] arrayNew)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayNew[count] = array[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(array, arrayNew);
PrintArray(arrayNew);