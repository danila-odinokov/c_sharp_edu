Console.Clear();

Console.WriteLine("Введите число строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int minValue = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int maxValue = int.Parse(Console.ReadLine());

int[,] arr = GetArray(rows, columns, minValue, maxValue);
PrintArray(arr);
int[] arr2 = TransformArray(arr);
Console.WriteLine(String.Join(" ",arr2));
BubbleSort(arr2);
Console.WriteLine(String.Join(" ",arr2));
ElementFrequencyCount(arr2);

void BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (array[i]>array[j])
            {
                int k = array[i];
                array[i] = array[j];
                array[j] = k;
            }
        }
    }
}

void ElementFrequencyCount(int[] array)
{
    int element = array[0];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == element) 
        {
            count++;
        }
        else
        {
            Console.WriteLine($"Количество элементов {element} = {count}");
            count=1;
            element = array[i];
        }
        if(i == array.Length-1)
        {
            Console.WriteLine($"Количество элементов {array[i]} = {count}");
        }
    }
}

int[] TransformArray(int[,] array)
{
    int count = 0;
    int [] result = new int[array.GetLength(0)*array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[count] = array[i,j];
            count++;
        }   
    }
    return result;
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}