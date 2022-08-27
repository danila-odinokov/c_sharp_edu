Console.Clear();

int a = new Random().Next(1,255);
Console.WriteLine(a);
Console.WriteLine(DecimalToBin(a));
Console.WriteLine(Convert.ToString(a,2));

int DecimalToBin(int dec)
{
    int result = 0;
    for (int i = 0; dec>0; i++)
    {
        result += (dec % 2) * (int)Math.Pow(10,i);
        dec = dec / 2;
    }
    return result;
}