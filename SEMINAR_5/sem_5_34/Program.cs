Console.Clear();

int[] arr = FillArray(10,100,999);
Console.WriteLine(String.Join(", ",arr));
Console.WriteLine(PosCount(arr));

// Массив случайных трёхзначных чисел
int[] FillArray(int size,int min_val, int max_val)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min_val,max_val+1);
    }
    return array;
}
// Подсчёт кол-ва чётных чисел
int PosCount(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {  
        if (array[i]%2==0)
        {
            count++;
        }
    }
    return count;
}