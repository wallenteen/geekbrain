//int numA=2, numB=3, numC=7, max=numA;
int numA = 44, numB = 5, numC = 78, max = numA;
//int numA=22, numB=3, numC=9, max=numA;

if (max < numB)
{
    max = numB;
}
if (max < numC)
{
    max = numC;
}
Console.Write("max number is ");
Console.WriteLine(max);