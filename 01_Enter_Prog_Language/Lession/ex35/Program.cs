// int[] numbers = new int[123];
// int length=numbers.Length;
// for (int i = 0; i < length; i++) numbers[i] = new Random().Next(1, 200);
// for (int i = 0; i < length; i++) Console.Write($"{numbers[i]} ");

// int sum = 0;
// for (int i = 0; i < length; i++)
// {

//     if (numbers[i] > 9 && numbers[i] < 100) sum = sum + 1;
//     Console.WriteLine($"{sum} - {numbers[i]} ");
// }
// Console.WriteLine();
// Console.WriteLine(sum);

int[] Create(int len)
{
    return new int[len];
}

void Fill(int[] array, int min, int max)
{
    int size = array.Length;
    for (int i = 0; i < size; i++) array[i] = new Random().Next(min, max);
}

string Print(int[] array)
{
    return "[" + String.Join(", ", array) + "] -> ";
}

int Find(int[] array, int findMin, int findMax)
{
    int sum = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > findMin && array[i] < findMax) sum++;
    }
    return sum;
}


int[] num = Create(123);

Fill(num, 1, 200);
Console.Write(Print(num));
Console.WriteLine(Find(num, 9, 100));