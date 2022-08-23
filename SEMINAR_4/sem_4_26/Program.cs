Console.Clear();

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

int counter(int number)
{
    int count = 0;
    if (number == 0) count++;
    while (number > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}

Console.WriteLine(counter(num));