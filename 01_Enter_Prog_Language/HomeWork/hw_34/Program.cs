// Задача 34: Задайте массив 
// заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] Create(int lengthArray)
{
    return new int[lengthArray];
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

int Find(int[] array, int howDiv)
{
    int sum = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % howDiv == 0) sum++;
    }
    return sum;
}

int[] num = Create(5);
Fill(num, 100, 1000);
Console.WriteLine((Print(num))+(Find(num, 2)));