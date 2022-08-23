Console.Clear();

int[] array = randomArray(8);

int[] randomArray(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0,10);
    }

    return arr;
}

Console.WriteLine($"[{string.Join(",",array)}]");
