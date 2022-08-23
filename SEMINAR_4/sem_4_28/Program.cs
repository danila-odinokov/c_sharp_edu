Console.Clear();

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

int multiply(int number)
{
    int count = 1;
    int output = 1;
    while (count <= number)
    {
        output = output * count;
        count++;
    }
    return output;
}

Console.WriteLine(multiply(num));