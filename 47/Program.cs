// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

 // m = 3, n = 4.

 // 0,5 7 -2 -0,2

 // 1 -3,3 8 -9,9

 // 8 7,8 -7,1 9

 double[,] result = CreateRandomArray(3, 4);
 Print2DArray(result);

 void Print2DArray(double[,] array)
 {
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             Console.Write($"{array[i, j]} ");
         }
         Console.WriteLine();
     }
 }

 double[,] CreateRandomArray(int m, int n)
 {
     double[,] array = new double[m, n];
     Random random = new Random();
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             array[i, j] = Math.Round(random.NextDouble() * (10 + 9) - 9, 1);
         }
     }
     return array;
 }