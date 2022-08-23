Console.Clear();

int[] arr = FillArray(6,-9,9);
Console.WriteLine(String.Join(", ",arr));
RevertArray(arr);
Console.WriteLine(String.Join(", ",arr));

int[] FillArray(int size,int min_val,int max_val)
{   
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min_val,max_val+1);
    }
    return array;
}

int[] RevertArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
    return array;
}