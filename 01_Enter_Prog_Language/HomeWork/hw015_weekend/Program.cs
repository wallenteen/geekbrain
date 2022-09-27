/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
------------------------------------*/
Console.WriteLine("Enter number of week day");
int day = int.Parse(Console.ReadLine());

if (day == 6 || day == 7) Console.WriteLine("Yes, this day is weekend "+day);
else if(day>0||day<6) Console.WriteLine("No, this day isn't weekend "+day);
else Console.WriteLine("Incorrect, in week only 7 days");
