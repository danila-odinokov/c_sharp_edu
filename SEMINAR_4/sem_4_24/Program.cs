Console.Clear();

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

int GetSum(int number)
{
    int sum = 0;

    while(number > 0)
    {
        sum += number%10;
        number /= 10;
    }

    return sum;
}
Console.WriteLine(GetSum(num));