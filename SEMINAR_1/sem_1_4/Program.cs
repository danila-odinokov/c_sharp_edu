Console.Clear();
Console.WriteLine("Введите число 1");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 3");
int c = int.Parse(Console.ReadLine());

if (a > b & a > c)
{
    Console.WriteLine($"Число {a} наибольшее");
}
else if (b > c)
{
    Console.WriteLine($"Число {b} наибольшее");  
}
else
{
    Console.WriteLine($"Число {c} наибольшее");  
}
