Console.Write("Enter username");
string username = Console.ReadLine();

if (username.ToLower() == "masha") //ToLower - все символы строки переходят в нижний регистр
{
    Console.WriteLine("Yo, it is Masha");
}
else
{
    Console.Write("Hi, ");
    Console.Write(username);
}