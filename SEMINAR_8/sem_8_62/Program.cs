Console.Clear();

int[,] arr = SpiralArray(4,4);
PrintArray(arr);

int[,] SpiralArray(int row,int column)
{
    int[,] spiral = new int[row,column];
    int count = 1;
    int n = 0;
    for (int i = 0; i < column; i++) // вправо до упора
    {
        spiral[0,i] = count;
        count++;
    }
    for (int i = n+1; i < row; i++) // вниз до упора
    {
        spiral[i,column-1] = count;
        count++;
    }
    for (int i = column/2; i > n; i--) // влево до упора
    {
        spiral[row-1,i] = count;
        count++;
    }
    for (int i = row-1; i > n+1; i--) // вверх до 1 ряда
    {
        spiral[i,n] = count;
        count++;
    }
    for (int i = 0; i < column/2; i++) // вправо до последнего столбца
    {
        spiral[n+1,i] = count;
        count++;
    }
    for (int i = n+1; i < row-1; i++) // вниз до последней строки
    {
        spiral[i,column/2] = count;
        count++;
    }
    spiral[row/2,n+1] = count++;
    return spiral;
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] / 10 == 0)
            {
                Console.Write($"0{array[i, j]} ");
            }
            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}