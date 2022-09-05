Console.Clear();
Console.WriteLine("Введите число строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int columns = int.Parse(Console.ReadLine());

int[,] arr = GetArray(rows,columns,-99,99);
PrintArray(arr);
Console.WriteLine("Среднее арифметическое столбцов:\n"
                    +$"{String.Join(" ",ArrayColumnMean(arr))}");
 
int[,] GetArray(int m,int n,int minValue, int maxValue)
{
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(minValue,maxValue+1);   
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
            Console.Write($"{array[i,j]} ");  
        }
        Console.WriteLine();
    }
}

double[] ArrayColumnMean(int[,] arr)
{
    double[] array = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            array[j] += arr[i,j];
        }
        array[j] /= arr.GetLength(0);
    }
    return array;
}