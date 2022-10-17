int[] array = new int[24];
int maxNumber = array[0];
int maxIndex = 0;

Console.WriteLine("Введите количество входов:");
int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Введите время {i + 1}-ого входа:");
    int enter = int.Parse(Console.ReadLine());

    Console.WriteLine($"Введите время {i + 1}-ого выхода:");
    int exit = int.Parse(Console.ReadLine());

    int sum = exit - enter;

    for (int k = enter; k < exit; k++)
    {
        array[k] = array[k] + 1;
    }
}

for (int i = 1; i < array.Length; i++)
{
    if (maxNumber < array[i])
    {
        maxNumber = array[i];
        maxIndex = i;
    }
}

Console.WriteLine($"Максимальное число посетителей было в {maxIndex} - {maxIndex + 1} часов");
