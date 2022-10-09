// // Напишите метод, который принимает на вход координаты двух точек
// //  и находит расстояние между ними в 3D пространстве.
// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53

// void writeMsg(string msg)
// {
//     Console.WriteLine(msg);
// }


// writeMsg("Введите XYZ координаты точки A");
// double sum = 0;
// int count = 3;
// double[] dotA = new double[count];
// for (int i = 0; i < dotA.Length; i++) dotA[i] = int.Parse(Console.ReadLine());
// //for (int i = 0; i < dotA.Length; i++) Console.Write(dotA[i] + " ");

// Console.WriteLine();
// writeMsg("Введите XYZ координаты точки B");
// double[] dotB = new double[count];
// for (int i = 0; i < dotB.Length; i++) dotB[i] = int.Parse(Console.ReadLine());
// //for (int i = 0; i < dotB.Length; i++) Console.Write(dotB[i] + " ");
// for (int i = 0; i < count; i++)
// {
//    sum=sum+(dotB[i]-dotA[i])*(dotB[i]-dotA[i]);  
// }
// //write(sum);
// sum = Math.Sqrt(sum);
// Console.WriteLine(sum);

double a = 3, b = 4, c = 0, d = 0, sum = 0;
c = a + b;
d = c * c;
sum = Math.Sqrt(d);

Console.WriteLine(sum);
