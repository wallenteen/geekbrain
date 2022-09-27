Console.WriteLine("Введите планируемое число:");
int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i = i + 2)
{
    if (i % 2 == 0)
    {
        Console.WriteLine("Четное число: " + i);
    }
}