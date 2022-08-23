Console.Clear();

int[] arr = FillArray(10,-999,999);
Console.WriteLine(String.Join(", ",arr));
Console.WriteLine(oddCount(arr));

// Массив случайных чисел
int[] FillArray(int size,int min_val, int max_val)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min_val,max_val+1);
    }
    return array;
}

// Подсчёт кол-ва элементов, стоящих на нечётных позициях
int oddCount(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        count+=array[i];
    }
    return count;
}