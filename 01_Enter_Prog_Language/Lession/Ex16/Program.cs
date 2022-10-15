// // string[,] table = new string[2, 5];
// // table[1, 2] = "word";

// // for (int row = 0; row < 2; row++)
// // {
// //     for (int columns = 0; columns < 5; columns++) Console.WriteLine($"={table[row, columns]}=");
// // }

// // int[,] matrix = new int[3, 4];
// // matrix[0, 1] = 8;

// // for (int p = 0; p < matrix.GetLength(0); p++)//matrix.GetLength(01) вызывает длину 0-строк, 1-столбцов
// // {
// //     for (int k = 0; k < matrix.GetLength(1); k++) Console.Write($"{matrix[p, k]} ");
// //     Console.WriteLine();
// // }

// // void PrintArray(int[,] matr)
// // {
// //     matr[0, 1] = 1;
// //     for (int p = 0; p < matr.GetLength(0); p++)//matrix.GetLength(01) вызывает длину 0-строк, 1-столбцов
// //     {
// //         for (int k = 0; k < matr.GetLength(1); k++) Console.Write($"{matrix[p, k]} ");
// //         Console.WriteLine();
// //     }
// // }

// // void Fill(int[,] matr)
// // {
// //     for (int i = 0; i < matr.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < matr.GetLength(1); j++) matr[i, j] = new Random().Next(1, 10);
// //     }
// //     Console.WriteLine();
// // }

// // Fill(matrix);
// // PrintArray(matrix);

// int[,] pic = new int[,]
// {
//     {0,0,0,1,1,0,0,0},
//     {0,0,1,0,0,1,0,0},
//     {0,1,0,0,0,0,1,0},
//     {1,0,0,0,0,0,0,1},
//     {1,0,0,0,0,0,0,1},
//     {0,1,0,0,0,0,1,0},
//     {0,0,1,0,0,1,0,0},
//     {0,0,0,1,1,0,0,0},
// };

// void Print(int[,] img)
// {
//     for (int i = 0; i < img.GetLength(0); i++)
//     {
//         for (int j = 0; j < img.GetLength(1); j++)
//         {
//             //Console.Write($"{img[i, j]} ");
//             if (img[i, j] == 0) Console.Write(" ");
//             else Console.Write("+");
//         }
//         Console.WriteLine();
//     }

// }

// void Fill(int row, int col)
// {
//     if (pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         Fill(row - 1, col);
//         Fill(row, col - 1);
//         Fill(row + 1, col);
//         Fill(row, col + 1);
//     }
// }

// Fill(2, 2);
// Print(pic);

// double Factorial(int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for(int i=1;i<40;i++) Console.WriteLine($"f{i}!={Factorial(i)}");


double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for(int i=1; i<40;i++) Console.WriteLine($"{i}={Fibonacci(i)}");