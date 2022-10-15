#region 
// Console.WriteLine("Укажите пространственную модель 1-2-3 мерная:");
// double count = double.Parse(Console.ReadLine());
// double sum = 0;
// double A=0, B=0;

// for (double i = 0; i < count; i++)
// {
// Console.WriteLine($"Введите {i + 1}-ое число точки А:");
// A = double.Parse(Console.ReadLine());
// }
// for (double i = 0; i < count; i++)
// {
// Console.WriteLine($"Введите {i + 1}-ое число точки В:");
// B = double.Parse(Console.ReadLine());
// }
#endregion

#region
//Дан массив, нужно сформировать массив из четных чисел
//1 Задать кол-во элементов
//2 Задать массив, в котором хранятся элементы
//3 Заполнить массив случайными числами
//4 Распечатать массив
//5 Найти коллическво четных чисел
//6 задать массив в котором будут четные числа
//7 Заполнить массив в котором будут четные числа
//8 распечатать массив с четными числами

// int size = new Random().Next(10, 20);//1
// int[] source = new int[size];//2
// for (int i = 0; i < size; i++)//3
// {
//     source[i] = new Random().Next(1, 10);
//     Console.Write(source[i] + " ");//4
// }
// #endregion

// int count = 0;
// for (int i = 0; i < size; i++) //5
// {
//     if (source[i] % 2 == 0) count++;
// }
// int[] evenItems = new int[count];//6
// int pos = 0;
// for (int i = 0; i < size; i++)//7
// {
//     if (source[i] % 2 == 0)
//     {
//         evenItems[pos]=source[i];
//         pos++;
//     }
// }
// Console.WriteLine();
// for (int i = 0; i < count; i++) Console.Write(evenItems[i]+" ");//8
#endregion

#region 
//1 создать метод получения псевдослучайного числа от min-max
//2 описать метод создающий массив с указанным кол-м элементов
//3 Описать метод заполнения массива псевдослучайными числами
//4 описать метод распечатывания массива
//5 описать метод нахождения четных чисел в массиве
//6 Описать метод финального решения


int GetIntValue(int min, int max)
{
    return new Random().Next(min, max);//1
}

int[] CreateArray(int size)//2
{
    return new int[size];
}

void Fill(int[] array)//3
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
    {
        array[i] = GetIntValue(1, 10);
    }
}

void Print(int[] array)//4
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int Search(int[] array)//5
{
    int size = array.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
}

int Final(int[] data, int count)//6
{
    int[] evenItems = new int[count];
    int pos = 0;
    int size = data.Length;
    for (int i = 0; i < size; i++)
    {
        if (data[i] % 2 == 0)
        {
            evenItems[pos] = data[i];
            pos++;
        }
    }
    return evenItems;
}

int length = GetIntValue(10, 20);
int[] collection = CreateArray(length);
Fill(collection);
Print(collection);
int count=Search(collection);
int[] result=Final(collection, count);
Print(result);
#endregion







