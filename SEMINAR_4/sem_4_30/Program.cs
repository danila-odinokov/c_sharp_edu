Console.Clear();

int[] array = GetRandomBinary(8);

int[] GetRandomBinary(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0,2);
    }

    return arr;
}

void PrintArray(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write($"{massiv[i]} ");
    }
    Console.WriteLine();
    Console.WriteLine($"[{string.Join(",",array)}]");
}
PrintArray(array);