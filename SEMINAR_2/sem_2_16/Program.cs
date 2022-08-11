Console.Clear();

Console.WriteLine("Введите число 1");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
int b = int.Parse(Console.ReadLine());

if(Math.Pow(b,2) == a)
{
    Console.WriteLine("b квадрат a");
}
if(Math.Pow(a,2) == b)
{
    Console.WriteLine("a квадрат b");
}
else
{
    Console.WriteLine("не является");
}