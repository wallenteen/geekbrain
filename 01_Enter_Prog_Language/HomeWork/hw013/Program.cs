/*int a = 1234, i=0;
string str = a.ToString();
int[] b = new int[str.Length];
//for( int i=0; i< str.Length; i++)
while (i < str.Length)
{
    b[i] = int.Parse(str[i].ToString());
} */
Console.Write("Enter N");
int a = Console.ReadLine( );
int i=0;
string str = n.ToString();
int[] b = new int[str.Length];
int length = n.Length;
Console.WriteLine(length);
while (i < length)
{
    b[i] = int.Parse(str[i].ToString());
} 