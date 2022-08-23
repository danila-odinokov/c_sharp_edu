Console.Clear();

Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine());

Console.WriteLine(powerOf(a,b));

int powerOf(int num_a,int num_b)
{
    int step = num_a;
    if (num_b == 0)
    {
        return 1;
    }
    else
    {
        for (int i = 1; i < num_b; i++)
        {
            num_a = num_a * step;
        }
        return num_a;
    }
}

