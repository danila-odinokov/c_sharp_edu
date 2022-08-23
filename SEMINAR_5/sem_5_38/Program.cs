Console.Clear();

double[] arr = FillArray(10,-999,999);
Console.WriteLine($"{MaxMin(arr):f3}");

// Массив случайных чисел
double[] FillArray(int size,int min_val, int max_val)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble()*1000;
    }
    return array;
}

// Разница между макс. мин.
double MaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]>max)
        {
            max = array[i];
        }
        if (array[i]<min)
        {
            min = array[i];
        }
    }
    return Math.Abs(max-min);
}