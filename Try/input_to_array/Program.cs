int a = 25687;
string str = a.ToString();
int[] b = new int[str.Length];
for (int i = 0; i < str.Length; i++)
{
    b[i] = int.Parse(str[i].ToString());
}
for (int i = 0; i < str.Length; i++)
{
    Console.WriteLine(b[i]);;
}
