// Урок 7. Как не нужно писать код. Часть 1

// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// int m = 3; 
// int n = 4; 
// double[,] array = new double[m, n];
// Random rnd = new Random();
// FillArray(array);
// Console.WriteLine();
// PrintArray(array);

// void PrintArray(double[,] array)
// {
//      for (int i = 0; i < m; i++)
//      { 
//          for (int j = 0; j < n; j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//      Console.WriteLine();
//      }
// }

// void FillArray(double[,] array)
// { 
//     for (int i = 0; i < m; i++)
//     { 
//          for (int j = 0; j < n; j++)
//         { 
//             array[i,j] = Convert.ToDouble(rnd.Next(-1000, 1000)/10.0);
//         }
//     }
// }

//End






// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

// int i = 3; 
// int j = 4; 

// int [,] arr = new int[i,j];
// CreateAndPrint(arr);
// System.Console.WriteLine();
 
// void CreateAndPrint(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i,j] = new Random().Next(1,10);
//             System.Console.Write(arr[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// Console.WriteLine("Введите № стоки :");
//  int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите № столбца :");
//  int b = Convert.ToInt32(Console.ReadLine());
 
//   if (a > i || b > j)
//     Console.WriteLine("Tакого числа нет");
//   else 
//   {
//         i = a-1 ; j = b-1 ;
//         System.Console.WriteLine();
//         System.Console.Write($" Число :  {arr[i,j]}");
//   }

//End


// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// int[,] array = new int[,] {
//        { 1, 4, 7, 2} ,
//        { 5, 9, 2, 3} ,
//        { 8, 4, 2, 4}
// };
// FindMean( array);

// void FindMean(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double result = 0 ;
//         int s = 0 ;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             result += array [i , j ];
//              s = i+1;
//         }
//         System.Console.Write ($"{result/s}  ");
//     }
// }

//  //End


