Console.Clear();
Console.WriteLine("Введите число 1");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
int b = int.Parse(Console.ReadLine());
if (a*a == b)
{
    Console.WriteLine("Квадрат числа 1 равен числу 2");
}
else
{
    Console.WriteLine("Квадрат числа 1 не равен числу 2");
}