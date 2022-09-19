//void метод - тот который ничего не возвращает (Return???)
int[] array = new int[10];
void FillArray(int[] collection)//fill-заполнить
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); //Создать(new) любое (Random) значение от1-10 (1,10) в массиве(collection) с индексом (index)
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

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