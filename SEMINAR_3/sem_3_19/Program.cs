// Console.Clear();
// Console.WriteLine("Введите число");
// string y = Console.ReadLine();
// y = y.Trim( new Char[] {'-'});

// if (y.Length != 5)
// {
//     Console.WriteLine("Введите пятизначное число");
// }
// else
// {
//     int x = int.Parse(y);
//     int[] array = new int[5];
    
//     for(int i=0; i<=4; i++)
//     {
//         array[i] = x % (int)Math.Pow(10,i+1) / (int)Math.Pow(10,i);
//     }

//     if (array[0] == array[4] && array[1] == array[3])
//     {
//         Console.WriteLine("Да");
//     }
//     else 
//     {
//         Console.WriteLine("Нет");
//     }
// }

Console.Clear();
string sNum = Console.ReadLine();

int length = sNum.Length;

for (int i = 0; i < length/2; i++)
{
    if (sNum[i] != sNum[length-1-i])
    {
        Console.WriteLine($"Строка {sNum} - не палиндром");
        return;
    }
}

Console.WriteLine($"Строка {sNum} - палиндром");