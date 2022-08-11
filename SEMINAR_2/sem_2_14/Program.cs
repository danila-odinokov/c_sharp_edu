Console.Clear();

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

if (a%7==0 && a%23==0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
