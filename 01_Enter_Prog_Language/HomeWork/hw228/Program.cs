//int number = int.Parse(Console.ReadLine());



Console.WriteLine("Введите планируемое количество чисел:");
double count = double.Parse(Console.ReadLine());
double sum = 0;
for (double i = 0; i < count; i++)
{
Console.WriteLine($"Введите {i + 1}-ое число:");
double number = double.Parse(Console.ReadLine());
sum = sum + number;
}
double average = sum / count;
Console.WriteLine(average);