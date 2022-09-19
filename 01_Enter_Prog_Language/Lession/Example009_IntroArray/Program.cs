/*
МАССИВ
ТИП ДАННЫХ[] ИМЯ = {Значение1,Значение2, ...}
int[] array = { 9, 28, 1, 32, 1990 }
int[] array = { 0, 0, 0, 0, 0 }
int[] array = new int[5];
int[] array = new int[]{ 0, 0, 0, 0, 0 }
int[] array = new int[5]{ 1, 0, 2, 0, 3 }
*/

//2*
//int a1 = 1, b1 = 2, c1 = 3, a2 = 4, b2 = 5, c2 = 6, a3 = 7, b3 = 8, c3 = 9;
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; //Указал массив данных
//index         0  1  2  3  4  5  6  7  8
//array[0]=12; //изменил у индекса [0] из массива array значение=12
//Console.WriteLine(array[0]); //Прочитать данные из массива, индекс 0

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result; //Вернуть в метод result
}
//int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));*/
int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));
Console.WriteLine(max);