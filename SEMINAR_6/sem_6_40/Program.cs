Console.Clear();
Console.WriteLine("Введите число 1");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 3");
int c = int.Parse(Console.ReadLine());

Console.WriteLine($"Треугольник существует? {TriangleCheck(a,b,c)}");

bool TriangleCheck(int first,int second,int third)
{
    if (first < second+third 
    && second < first+third 
    && third < first+second)
    return true;
    else return false;
}