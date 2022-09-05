Console.Clear();
Console.WriteLine("Введите число строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int columns = int.Parse(Console.ReadLine());

int[,] arr = GetArray(rows,columns,-99,99);
PrintArray(arr);
Console.WriteLine("Введите номер строки");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int b = int.Parse(Console.ReadLine());
Console.WriteLine(FindElementByIndex(arr,a,b));
 
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

int FindElementByIndex(int[,] array,int row,int col)
{
    if (row >= array.GetLength(0) || col >= array.GetLength(1))
    {
        Console.WriteLine("Такого числа в массиве нет");
        return 0;
    }
    else
    {
        return array[row,col];
    }
}