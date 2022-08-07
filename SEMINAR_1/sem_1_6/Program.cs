Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
a = (a % 10) % 2;

if (a==0)
    {
        Console.WriteLine("Число чётное");
    }
else
    {
        Console.WriteLine("Число нечётное");
    }   
    