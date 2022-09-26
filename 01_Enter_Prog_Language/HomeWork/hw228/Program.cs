//Задача 228: Напишите программу, которая принимает на вход семь чисел, и находит их среднее арифметическое
//1 2 3 4 5 6 7-> 4
//10 20 30 40 50 60 70 -> 40

//int[] array = { 1, 2, 3, 4, 5, 6, 7 };
int[] array = { 10, 20, 30, 40, 50, 60, 70 };
int length = array.Length;
int index = 0;
int sum = 0;

Console.WriteLine("Привет, эта прога найдет среднее арифметическое указанных цифр.");

while (index < length)
{
    sum = sum + array[index];
    index++;
}
Console.WriteLine("Среднее арифметическое = " + sum / length);