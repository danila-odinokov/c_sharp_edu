Console.Clear();

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

if (a==7 || a==6)
{
    Console.WriteLine("Да");
}
else if (a>0 && a<6)
{
    Console.WriteLine("Нет");
}
else 
{
    Console.WriteLine("Указано неверное число");
}