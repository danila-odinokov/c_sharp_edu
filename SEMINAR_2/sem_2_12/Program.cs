Console.Clear();

Console.WriteLine("Введите число 1");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
int b = int.Parse(Console.ReadLine());

if (a%b == 0)
{
    Console.WriteLine($"Число {a} кратно числу {b}");   
}
else 
{
    Console.WriteLine($"Число {a} не кратно числу {b}\nОстаток {a%b}");
}