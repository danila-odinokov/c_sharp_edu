Console.Clear();

int[] arr = TwoDigitArray(90);
int[,,] arr2 = Array3D(2,2,2,arr);
Print3DArray(arr2);

int[] TwoDigitArray(int length)
{
    int a = 10;
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = a;
        a++;
    }
    return array;
}

int[,,] Array3D(int x,int y,int z,int[] inArray)
{
    int a = 0;
    int[,,] array = new int[x,y,z];
    for (int i = 0; i < z; i++)
    {
        for (int j = 0; j < x; j++)
        {  
            for (int k = 0; k < y; k++)
            {
                array[j,k,i] = inArray[a];
                a++;
            }
        }
    }
    return array;
}

void Print3DArray(int [,,] array)
{
    for (int i = 0; i < array.GetLength(2); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {  
            for (int k = 0; k < array.GetLength(0); k++)
            {
                Console.Write($"{array[j,k,i]}({j},{k},{i})");
            }
            Console.WriteLine();
        }
    }  
}