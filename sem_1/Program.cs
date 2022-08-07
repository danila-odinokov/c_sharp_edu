Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

int sqr = a * a;
Console.WriteLine($"Квадрат числа {a} равен {sqr}");

sqr = Convert.ToInt32(Math.Pow(a,2));

Console.WriteLine($"Квадрат числа {a} равен {sqr}");