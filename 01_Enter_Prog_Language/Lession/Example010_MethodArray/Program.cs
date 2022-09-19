int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int n = array.Length; //длиннаLength массива array
int find = 4;
int index = 0;

while (index < n)
{
    if (array[index] == find) //Если число из массива с индексом == искомому
    {
        Console.WriteLine(index);
        break; //Прервать цикл
    }

    index++;
}
