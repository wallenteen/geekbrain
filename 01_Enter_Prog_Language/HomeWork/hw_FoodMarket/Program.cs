int[] array = new int[24];
int MaxNumber = array[0];
int MaxIndex = 0;
Console.WriteLine("Введите количество посетителей (например 100):");
int visit = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество входов:");
int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Введите время {i + 1}-ого входа:");
    int Ent = int.Parse(Console.ReadLine());

    Console.WriteLine($"Введите время {i + 1}-ого выхода:");
    int Out = int.Parse(Console.ReadLine());

    int sum = Out - Ent;
    Console.WriteLine($"{sum}/{visit / sum}");

    for (int k = Ent; k < array.Length; k++)
    {
        if (k < Out) array[k] = array[k] + (visit / sum);
    }
}

for (int i = 1; i < array.Length; i++)
{
    if (MaxNumber < array[i])
    {
        MaxNumber = array[i];
        MaxIndex = i;
    }
}

Console.WriteLine($"Максимальное число посетителей было в {MaxIndex} - {MaxIndex + 1} часов");
