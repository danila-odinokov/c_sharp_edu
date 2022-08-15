Console.Clear();

Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());
int y = 1;

while (y <= x)
{
    Console.WriteLine($"x={y} --> x^2={y*y}");
    y++;
}