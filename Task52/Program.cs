// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.WriteLine("Введите количество строк массива:");
int rows = int.Parse(Console.ReadLine()!)!;
Console.WriteLine("Введите количество столбцов массива:");
int columns = int.Parse(Console.ReadLine()!)!;

double[,] array = GetArray(rows, columns, 1, 10);
PrintArray(array);
Console.WriteLine("Среднее арифметическое каждого столбца:");
GetAverage(array);

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetAverage(double[,] inArray)
{
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            average = average + inArray[i, j];
        }
        average = average / inArray.GetLength(0);
        Console.Write(Math.Round(average, 2) + " ");
    }
}