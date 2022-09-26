/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
------------------------------------*/

int[] array = { 6, 7 };//weekend
int[] day = { 1, 2, 3, 4, 5 };
int n = array.Length;
Console.WriteLine("Enter number of week day");
int find = int.Parse(Console.ReadLine());
int index = 0;
int a = 0, b = 0;

while (index < n)
{
    if (array[index] == find) a = array[index];
    else if (day[index] == find) b = day[index];
    index++;
}
if (find == a) Console.WriteLine("Yes this day is weekend " + a);
if (find == b) Console.WriteLine("No, this day isn't weekend " + b);
if (find > 7) Console.WriteLine("Incorrect, in week only 7 days");
