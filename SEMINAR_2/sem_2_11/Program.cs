Console.Clear();

int a = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число {a}");
int first = (a / 100)*10; 
int third = a%10;
int result = first+third;

Console.WriteLine($"Результат {result}");