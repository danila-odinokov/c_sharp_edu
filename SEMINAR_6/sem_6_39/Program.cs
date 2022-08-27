Console.Clear();

int[] arr = FillArray(10,-99,99);
Console.WriteLine(String.Join(" ",arr));
int[] reverseArray = ReverseArray(arr);
Console.WriteLine(String.Join(" ",reverseArray));
FlipArray(arr);
Console.WriteLine(String.Join(" ",arr));

int[] FillArray(int size,int min_val,int max_val)
{   
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min_val,max_val+1);
    }
    return array;
}

// Способ 1
void FlipArray(int [] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        int k = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length-i-1] = k;   
    }
}

// Способ 2
int[] ReverseArray(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length-1-i];
    }
    return result;
}


