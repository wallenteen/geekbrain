// Напишите метод, который принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Этот скрипт покажет числа до указанного числа в 3 степени");
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i <= num; i++)
{
    Console.WriteLine($"{i} в 3й степени ={i * i * i}");
}