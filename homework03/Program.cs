int[] Array(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Введите переменную под индексом[{i}]: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

Console.Write("Введите длинну массива: ");
int Size = Convert.ToInt32(Console.ReadLine());
int[] array = Array(Size);
PrintArray(array);