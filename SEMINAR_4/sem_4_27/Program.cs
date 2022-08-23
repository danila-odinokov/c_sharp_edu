Console.Clear();

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

int numberSum(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}

Console.WriteLine(numberSum(a));
