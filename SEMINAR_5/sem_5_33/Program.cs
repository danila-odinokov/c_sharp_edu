Console.Clear();

int[] arr = FillArray(5,-9,9);
Console.WriteLine(String.Join(", ",arr));
Console.WriteLine("Введите искомое число");
int num = int.Parse(Console.ReadLine());
FindNumArray(arr,num);

int[] FillArray(int size,int min_val, int max_val)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min_val,max_val);
    }
    return array;
}

void FindNumArray(int[] array,int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            Console.WriteLine($"Число найдено, индекс числа = {i}");
            return;
        }
    }
    Console.WriteLine("Число не найдено");
}