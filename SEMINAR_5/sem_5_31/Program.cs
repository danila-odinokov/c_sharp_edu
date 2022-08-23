Console.Clear();

int[] arr = FillArray(12,-9,9);
Console.WriteLine(String.Join(", ",arr));
Console.WriteLine(PosSum(arr));
Console.WriteLine(NegSum(arr));

int[] FillArray(int size,int min_val,int max_val)
{   
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min_val,max_val+1);
    }
    return array;
}

int PosSum(int[] massiv)
{   
    int sum = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        if (massiv[i]>0) 
        {
            sum+=massiv[i];
        } 
    }
    return sum;
}

int NegSum(int[] massiv)
{   
    int sum = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        if (massiv[i]<0) 
        {
            sum+=massiv[i];
        } 
    }
    return sum;
}

