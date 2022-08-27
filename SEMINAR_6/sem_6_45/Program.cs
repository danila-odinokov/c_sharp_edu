Console.Clear();

int [] arr = FillArray(10,-99,99);
Console.WriteLine(String.Join(" ",arr));
int [] arr2 = CopyArray(arr);
Console.WriteLine(String.Join(" ",arr2));

int[] FillArray(int size,int min_val,int max_val)
{   
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min_val,max_val+1);
    }
    return array;
}

int[] CopyArray(int [] array)
{
    int[] copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
    }
    return copy;
}