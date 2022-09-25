//Console.Clear();
int count = 10;
int[] array = new int[count];
int find = new Random().Next(1, 21);
int index = 0;

Console.Write("Find ");
Console.WriteLine(find);

while (index < count)
{
    array[index] = new Random().Next(1, 101);
//    Console.Write(array[index] + " ");
    index++;
}
index = 0;
//bool element = false;

while (index < count)
{
    if (array[index] == find)
    {
       // element = true;
       Console.WriteLine("Yes");
    }
     index++;
}

//if (element)
//{
    Console.WriteLine("\nThis number have");
//}
