// Напишите метод, который принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Enter 5digit number");
int num = int.Parse(Console.ReadLine());
string Num = Convert.ToString(num);
int[] Array = new int[Num.Length];
int i;
int temp = 0;

for (i = 0; i < Num.Length; i++)
{
    Array[i] = Convert.ToInt32(Num[i].ToString());
    Console.Write(Array[i] + " ");
}

for (i = 0; i < Num.Length / 2; i++)
{
    if (Array[i] == Array[Num.Length - i - 1]) temp++;
}

if (temp == Num.Length / 2) Console.WriteLine("Yes");
else Console.WriteLine("No");


