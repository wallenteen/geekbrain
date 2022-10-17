int size = 6;
int[] array = new int[size];
for (int i = 0; i < size; i++) {array[i] = new Random().Next(-9, 10);
Console.Write((array[i])+", ");
}

for (int i = 0; i < size; i++)
{
    array[i]=array[i]-(array[i]*2);
    Console.Write((array[i])+", ");
}
