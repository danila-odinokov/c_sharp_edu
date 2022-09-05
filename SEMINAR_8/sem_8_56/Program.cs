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
MinimalSumRow(arr);

void MinimalSumRow(int[,] array)
{
    int [] array2 = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array2[i] += array[i,j];
        }
    }

    int minimalSumRowNumber = 0;
    for (int k = 1; k < array2.Length; k++)
    {
        if (array2[k]<array2[k-1])
        {
            minimalSumRowNumber = k;
        }
    }
    Console.WriteLine($"строка {minimalSumRowNumber+1}");
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