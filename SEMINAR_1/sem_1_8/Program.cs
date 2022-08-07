Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int b = 0;

while (b < a-1)
{
    b = b + 2;
    Console.Write(b + " ");
}
