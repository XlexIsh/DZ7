// Напишите программу, которая на вход принимает число и ищет в двумерном массиве, 
// и возвращает индексы этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 7 -> 0 , 2
// 5 -> 1 , 0

Console.WriteLine("Введите число: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);

if (isNumber != true)
{
    Console.WriteLine("Ошибка!");
    return;
}

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
            array[i, j] = random.Next(-9, 10);
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

int[] arrayIndex = GetIndex(array, number);
PrintArray(arrayIndex);

int[] GetIndex(int[,] array, int number)
{
    int[] arrayIndex = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                arrayIndex[0] = i;
                arrayIndex[1] = j;
            }
            else
            {
                arrayIndex[0] = 1000;
                arrayIndex[1] = 1000;
            }
        }
    }
    return arrayIndex;
}

void PrintArray(int[] arrayIndex)
{
    int i = arrayIndex[0];
    int j = arrayIndex[1];
    if (i != 1000 && j != 1000)
    {
        Console.WriteLine($"{number} => {i}, {j}");
    }
    else
    {
        Console.WriteLine("число отсутствует");
    }

}