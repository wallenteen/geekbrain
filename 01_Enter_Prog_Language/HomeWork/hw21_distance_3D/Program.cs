// Напишите метод, который принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double sum = 0;
void writeMsg(string msg)
{
    Console.WriteLine(msg);
}
double[] CreateArray(int size = 3)
{
    return new double[size];
}
void Fill(double[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++) array[i] = int.Parse(Console.ReadLine());
}
void Print(double[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++) Console.Write(array[i] + " ");
}
void Empty()
{
    Console.WriteLine();
}
double Summ(double[] arrayB, double[] arrayA, int count)
{

    for (int i = 0; i < count; i++) sum = sum + (arrayB[i] - arrayA[i]) * (arrayB[i] - arrayA[i]);
    return sum;
}

writeMsg("Введите XYZ координаты точки A");
double[] dotA = CreateArray();
Fill(dotA);
Empty();
writeMsg("Введите XYZ координаты точки B");
double[] dotB = CreateArray();
Fill(dotB);
Print(dotA);
Empty();
Print(dotB);
Empty();

void Final(){
    sum=Math.Sqrt(Summ(dotB, dotA, dotB.Length));
    writeMsg("Расстояние = ");
    Console.WriteLine(sum);
}
Final();
