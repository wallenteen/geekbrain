// 1 группа методов: Ничего не возвращают и не принимают
void Method1()
{
    Console.WriteLine("text");
}
Method1();

//2 группа методов методы, которые ничего не возвразают, но принимают аргументы
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("text msg");
void Method21(string msg, int count)
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(msg);
    }
}
//Method21(msg: "text", 4);
Method21(count: 4, msg: "new text");

//3 группа возвращают, но не принимают
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

//4 группа методов что-то принимает и чтото возвращает
string Method4(int count, string text)
{

    string result = String.Empty;
    for (int i = 0; i < count; i++) result = result + text;
    return result;
}
string res = Method4(10, "0");
Console.WriteLine(res);

//Цикл for и цикл в цикле(таблица умножения)
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i}x{j}={i * j}");//$-интерполяция строк
    }
    Console.WriteLine();
}

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?



//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + " вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s="qwerty"
//          012345
//s[3]-r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();


int[] array = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(array);
SelectionSort(array);

PrintArray(array);