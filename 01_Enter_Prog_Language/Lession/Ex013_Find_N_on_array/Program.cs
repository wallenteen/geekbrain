//Console.Clear();
int count = 10;
int[] array = new int[10];
int find = new Random().Next(1, 10);
int index = 0;
Console.Write("Find ");
Console.WriteLine(find);

while (index < count)
{
    array[index] = new Random().Next(1, 10);
    Console.Write(array[index] + " ");
    index++;
}
index = 0;
bool element = false;

while (index < count)
{
    if (array[index] == find)
    {
        element = true;
        index++;
    }
}

if (element)
{
    Console.WriteLine("\nThis number have");
}
