// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

 // Например, задан массив:
 // 1 4 7 2
 // 5 9 2 3
 // 8 4 2 4
 // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

 int[,] array = CreateRandomArray(4, 4);
 Print2DArray(array);

 int[,] CreateRandomArray(int m, int n)
 {
     int[,] array = new int[m, n];
     Random random = new Random();
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             array[i, j] = random.Next(0, 10);
         }
     }
     return array;
 }

 void Print2DArray(int[,] array)
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

 double[] GetAverage(int[,] array)
 {
     double[] arrayAverage = new double[array.GetLength(1)];
     for (int j = 0; j < array.GetLength(1); j++)
     {
         double average = 0;
         for (int i = 0; i < array.GetLength(0); i++)
         {
             average = average + array[i, j];
         }
         arrayAverage[j] = average / array.GetLength(0);
     }
     return arrayAverage;
 }

 void PrintArrayAverage(double[] arrayAverage)
 {
     int length = arrayAverage.Length;
     Console.Write("Среднее арифметическое каждого столбца: ");
     for (int i = 0; i < length; i++)
     {
         Console.Write($"{arrayAverage[i]}");
         if (i != length - 1)
         {
             Console.Write("; ");
         }
     }
 }

 double[] arrayAverage = GetAverage(array);
 PrintArrayAverage(arrayAverage);