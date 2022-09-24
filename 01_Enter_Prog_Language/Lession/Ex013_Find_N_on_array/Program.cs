int count = 10;
int[] array = new int[10];
int find = new Random().Next(1, 20);
int index = 0;
Console.Write("Find ");
Console.WriteLine(find);

while (index < count)
{
    array[index] = new Random().Next(1, 100);
    Console.Write(array[index]+" ");
    index++;
}
index = 0;

while (index < count)
{
    if (array[index] == find) Console.WriteLine("Yes");
    index++;
}
Console.WriteLine("end");