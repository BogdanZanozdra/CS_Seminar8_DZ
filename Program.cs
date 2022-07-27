// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

// Console.WriteLine("Введите количество строк");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m, n];
// GetArray(array);
// PrintArray(array);

// Console.WriteLine("Отсортированный массив: ");
// SortArrayRows(array);
// PrintArray(array);

// void SortArrayRows(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
// }

// void GetArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(10);
//     }
//   }
// }

// void PrintArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + "\t");
//     }
//     Console.WriteLine();
//   }
// }


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// Console.WriteLine("Введите количество строк");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m, n];
// GetArray(array);
// PrintArray(array);

// int minSumRow = 0;
// int sumRow = SumRowElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int tempSumLine = SumRowElements(array, i);
//   if (sumRow > tempSumLine)
//   {
//     sumRow = tempSumLine;
//     minSumRow = i;
//   }
// }

// Console.WriteLine($"наименьшая сумма элементов - {sumRow} ");
// Console.WriteLine($"строкa с наименьшей суммой элементов - {minSumRow+1}");

// int SumRowElements(int[,] array, int i)
// {
//   int sumLine = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sumLine += array[i,j];
//   }
//   return sumLine;
// }

// void GetArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(10);
//     }
//   }
// }

// void PrintArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + "\t");
//     }
//     Console.WriteLine();
//   }
// }


         


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Console.WriteLine("Введите количество строк 1-й матрицы: ");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число столбцов 1-й матрицы (и строк 2-й): ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов 2-й матрицы:  ");
// int p = Convert.ToInt32(Console.ReadLine());

// int[,] firstMartrix = new int[m, n];
// GetArray(firstMartrix);
// Console.WriteLine("Первая матрица:");
// PrintArray(firstMartrix);

// int[,] secomdMartrix = new int[n, p];
// GetArray(secomdMartrix);
// Console.WriteLine("Вторая матрица:");
// PrintArray(secomdMartrix);

// int[,] resultMatrix = new int[m,p];

// MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
// Console.WriteLine("Произведение первой и второй матриц:");
// PrintArray(resultMatrix);

// void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[i,k] * secomdMartrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }


// void GetArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(1, 10);
//     }
//   }
// }

// void PrintArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + "\t");
//     }
//     Console.WriteLine();
//   }
// }
