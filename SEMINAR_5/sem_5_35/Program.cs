Console.Clear();

int[] arr = FillArray(123,-999,999);
Console.WriteLine(inMinMax(arr,10,99));

int[] FillArray(int size,int min_val, int max_val)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min_val,max_val);
    }
    return array;
}

int inMinMax(int[] array,int min_val,int max_val)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<=max_val && array[i]>=min_val)
        {
        count++;
        }
    }
    return count;
}