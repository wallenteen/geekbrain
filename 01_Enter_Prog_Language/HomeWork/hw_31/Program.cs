int size = 12;
int[] array = new int[size];
for (int i = 0; i < size; i++) {array[i] = new Random().Next(-9, 10);
Console.WriteLine((array[i])+", ");
}
int plus = 0, minus = 0;
for (int i = 0; i < size; i++)
{
    
    if (array[i] < 0) minus = minus + array[i];
    else if(array[i] > 0) plus = plus + array[i];
}
Console.WriteLine($"{plus}, {minus}");