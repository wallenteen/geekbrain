// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int Find(int[] array)
{
    int sum = 0;
    int size = array.Length;
    for (int i = 1; i < size; i+=2) sum=sum+array[i];
    return sum;
}

int[] num = Create(5);
Fill(num, 100, 1000);
Console.WriteLine((Print(num))+(Find(num)));