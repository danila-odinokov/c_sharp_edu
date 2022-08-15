Console.Clear();

Console.WriteLine("Введите трёхзначное число");
int a = int.Parse(Console.ReadLine());

a = (a % 100) / 10;
Console.WriteLine($"Вторая цифра числа {a}");