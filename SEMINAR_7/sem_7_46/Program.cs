Console.Clear();

int[,] arr = GetArray(4,4,0,99);
PrintArray(arr);

int[,] GetArray(int m,          // число строк
                int n,          // число столбцов
                int minValue,   // мин. значение
                int maxValue)   // макс. значение
{
    int[,] array = new int[m,n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(minValue,maxValue);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
