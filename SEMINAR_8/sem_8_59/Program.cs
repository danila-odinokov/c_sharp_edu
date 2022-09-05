Console.Clear();

Console.WriteLine("Введите число строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int minValue = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int maxValue = int.Parse(Console.ReadLine());

int[,] arr = GetArray(rows,columns,minValue,maxValue);
PrintArray(arr);
int[] coordinates = FindLowestElement(arr);
RemoveLowestNumCrossing(arr,coordinates);

int[,] RemoveLowestNumCrossing(int[,] array,int[] coord)
{
    int[,] array2 = new int [array.GetLength(0)-1,array.GetLength(1)-1];
    int row = 0, col = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == coord[0]) continue;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == coord[1]) continue;
            array2[row,col] = array[i,j];
            col++;
        } 
        row++; 
    }
    return array2;
}

int[] FindLowestElement(int[,] array)
{
    int[] result = new int[2];
    int lowestNum = array[0,0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < lowestNum) 
            {
                lowestNum = array[i,j];
                result[0] = i;
                result[1] = j;
            }  
        }
    }
    return result;
}

int[,] GetArray(int m,int n,int min, int max)
{
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(min,max+1);   
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
            Console.Write($"{array[i,j]} ");  
        }
        Console.WriteLine();
    }
}