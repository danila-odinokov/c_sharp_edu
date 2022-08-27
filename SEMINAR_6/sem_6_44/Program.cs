Console.Clear();
Console.WriteLine("Введите число N");
int a = int.Parse(Console.ReadLine());
int [] arr = Fib(a);
Console.WriteLine(String.Join(" ",arr));

int[] Fib(int n)
{
    int [] array = new int[n];
    array[0] = 0;
    array[1] = 1;
    for (int i=2; i < n; i++)
    {
        array[i] = array[i-1]+array[i-2];
    }
    return array;
}