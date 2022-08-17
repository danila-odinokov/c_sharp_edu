Console.Clear();

Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());
int y = 1;

while (y <= x)
{
    Console.Write(Math.Pow(y,3) + " ");
    y++;
}