int size = 6;
int[] array = new int[size];
for (int i = 0; i < size; i++) {array[i] = new Random().Next(-9, 10);
Console.Write((array[i])+", ");
}
Console.WriteLine();
for (int i = 0; i < size/2; i++)
{
    int sum=array[i]*array[size-i-1];
    Console.WriteLine($"{array[i]} x {array[size-i-1]}={sum}");
}
