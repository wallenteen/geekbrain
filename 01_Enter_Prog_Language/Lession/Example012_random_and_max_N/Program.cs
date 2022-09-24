int n = new Random().Next(10, 100);//(10,1000]
Console.Write("Привет, загадано число ");
Console.WriteLine(n);

int a = n / 10;
int b = n % 10;
Console.Write("Максимальное число ");
if (a>b){
    Console.WriteLine(a);
}
else{
    Console.WriteLine(b);
}