Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
a = a % 10;
Console.WriteLine($"Последняя цифра числа {a}");
