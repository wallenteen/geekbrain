// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] Create(int len)
{
    return new double[len];
}

void Fill(double[] array, int min, int max)
{
    int size = array.Length;
    for (int i = 0; i < size; i++) array[i] = new Random().Next(min, max);
}

string Print(double[] array)
{
    return "[" + String.Join(", ", array) + "] -> ";
}

double Find(double[] array)
{
    double minNumber = array[0];
    double maxNumber = array[1];
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array[i] < minNumber) minNumber = array[i];
        else if (array[i] > maxNumber) maxNumber = array[i];
    }
    
    double sum = maxNumber - minNumber;
    return sum;
}


double[] num = Create(7);

Fill(num, 1, 10);
Console.Write(Print(num));
Console.WriteLine(Find(num));


