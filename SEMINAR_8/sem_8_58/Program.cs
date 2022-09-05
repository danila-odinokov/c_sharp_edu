Console.Clear();

Console.WriteLine("Введите число строк матрицы A");
int rowA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов матрицы A");
int columnA = int.Parse(Console.ReadLine());
Console.WriteLine("Число строк матрицы B = числу столбцов матрицы A");
Console.WriteLine("Введите число столбцов матрицы B");
int columnB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int minValue = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int maxValue = int.Parse(Console.ReadLine());

int[,] arrA = GetArray(rowA,columnA,minValue,maxValue);
PrintArray(arrA);
int[,] arrB = GetArray(columnA,columnB,minValue,maxValue);
PrintArray(arrB);
int[,] arrAB = ArrayMultiply(arrA,arrB);
PrintArray(arrAB);

int[,] ArrayMultiply(int[,] A, int[,] B)
{
    int[,] result = new int[A.GetLength(0),B.GetLength(1)];
    for (int resultRow = 0; resultRow < result.GetLength(0); resultRow++)
    {
        for (int resultCol = 0; resultCol < result.GetLength(1); resultCol++)
        {
            for (int p = 0; p < A.GetLength(1); p++)
            {
                result[resultRow,resultCol] += A[resultRow,p] * B[p,resultCol];
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