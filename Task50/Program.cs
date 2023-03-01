// Задача 50. Напишите программу, которая на вход принимает позиции 
// лемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> по такому индексу нет элемента.

Console.Clear();
Console.WriteLine("Введите количество строк массива:");
int rows = int.Parse(Console.ReadLine()!)!;
Console.WriteLine("Введите количество столбцов массива:");
int columns = int.Parse(Console.ReadLine()!)!;

int[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);

Console.WriteLine("Введите номер строки в массиве:");
int checkRows = int.Parse(Console.ReadLine()!)!;
Console.WriteLine("Введите номер столбца:");
int checkColumns = int.Parse(Console.ReadLine()!)!;
CheckArray(array, checkRows, checkColumns);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
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

int CheckArray(int[,] inArray, int r, int c)
{
    int checkResult = inArray[0, 0];
    if (r < inArray.GetLength(0)
    && c < inArray.GetLength(1)
    && r >= 0
    && c >= 0)
    {
        checkResult = inArray[r, c];
        Console.WriteLine($"По индексу [{r},{c}] находится элемент {checkResult}");
    }
    else
    {
        Console.WriteLine($"По индексу [{r},{c}] элемента не существует");
    }
    return checkResult;
}
