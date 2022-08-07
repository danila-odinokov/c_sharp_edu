Console.Clear();
int b;

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

if(a<0) 
    {
        b = a;
        a = -a;
    }
else
    {
        b = -a;
    }
while (b <= a)
{
    Console.Write(b+" ");
    b = b + 1;
}