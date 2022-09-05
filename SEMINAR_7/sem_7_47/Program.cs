Console.Clear();
Console.WriteLine("Введите число строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int columns = int.Parse(Console.ReadLine());
double[,] arr = GetArray(rows,columns);
PrintArray(arr);
 
double[,] GetArray(int m,int n)
{
    double[,] array = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double number = new Random().Next(-99,100);
            array[i,j] = new Random().NextDouble()*number;   
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]:f1} ");  
        }
        Console.WriteLine();
    }
}