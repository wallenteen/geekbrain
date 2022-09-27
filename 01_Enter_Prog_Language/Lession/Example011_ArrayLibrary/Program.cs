
void FillArray(int[] collection)//метод заполнения числами массива
{
    int length = collection.Length;
    for (int index = 0; index < length; index++) collection[index] = new Random().Next(1, 10); //Создать(new) любое (Random) значение от1-10 (1,10) в массиве(collection) с индексом (index)
}

void PrintArray(int[] col)//Метод void который будет печатать массив
{
    int count = col.Length;
    for (int position = 0; position < count; position++) Console.WriteLine(col[position]);
}

int[] array = new int[10];//Создать новы массив в котором будет 10 элементов

FillArray(array);
PrintArray(array);

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //указал вместо 0 для того чтобы в результате поиска числа если нет искомого, выдать его отсутствие как -1

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
FillArray(array);
array[4] = 4;//принудительно вписать в индекс 4 число 4
array[9] = 9;
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 98);
Console.WriteLine(pos);