Console.Clear();
Console.WriteLine("Сколько чисел требуется ввести?");
int n = int.Parse(Console.ReadLine());
int[] arr = UserInput(n);
Console.WriteLine($"Кол-во положительных чисел - {PositiveNumArray(arr)}");

int[] UserInput(int m)
{
    int[] array = new int[m];
    for (int i = 0; i < m; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

int PositiveNumArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) result++;
    }
    return result;
}