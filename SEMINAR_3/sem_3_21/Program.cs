Console.Clear();

Console.WriteLine("Введите число x1:");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число y1:");
double y1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите число x2:");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число y2:");
double y2 = double.Parse(Console.ReadLine());

double a = Math.Pow(x1 - x2,2);
double b = Math.Pow(y1 - y2,2);
double c = Math.Sqrt(a+b);

Console.WriteLine($"Расстояние между точками {c:f3}");