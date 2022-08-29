Console.Clear();

Console.WriteLine("Введите число строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int columns = int.Parse(Console.ReadLine());

int[,] arr = GetArrayRowColumnSum(rows,columns);
PrintArray(arr);
arr = CheckEvenArray(arr);
PrintArray(arr);

int[,] GetArrayRowColumnSum(int m,int n)
{
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(0,100);   
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

int[,] CheckEvenArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0) array[i,j] *= array[i,j];
        }
    }
    return array;
}