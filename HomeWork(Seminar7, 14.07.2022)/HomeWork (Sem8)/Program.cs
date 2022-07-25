/*
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. 
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
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = GetArray(rows, columns, 2, 10);
PrintArray(array);
Console.WriteLine("----------------------- ");

void SortArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            //доп.цикл для сравнения рядом стоящих элементов
            for (int t = j + 1; t < inArray.GetLength(1); t++)
            {
                if (inArray[i, t] > inArray[i, j])
                {
                    //делаем замену через временную переменную temp
                    int temp = inArray[i, j];
                    inArray[i, j] = inArray[i, t];
                    inArray[i, t] = temp;
                }
            }
        }
    }
    PrintArray(inArray);
}
SortArray(array);


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
    for (int row = 0; row < inArray.GetLength(0); row++)
    {
        for (int column = 0; column < inArray.GetLength(1); column++)
        {
            Console.Write($"{inArray[row, column]}     ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 7);
PrintArray(array);

int GetRowNumbers(int[,] array)
{
    int row = 0;
    int minsum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minsum = minsum + array[0, j];
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }

        if (minsum > sum)
        {
            minsum = sum;
            row = i;
        }
    }
    return row;
}
Console.WriteLine($"Индекс строки с наименьшей суммой элементов: {GetRowNumbers(array)}");


//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();
//я пробовала написать свою программу. Сначала не вышло. Переписывала уже сегодня. Если возможно, прошу дать комментарии по оптимизации

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
    for (int row = 0; row < inArray.GetLength(0); row++)
    {
        for (int column = 0; column < inArray.GetLength(1); column++)
        {
            Console.Write($"{inArray[row, column]}     ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк первого массива: ");
int rowsA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов первого массива: ");
int columnsA = Convert.ToInt32(Console.ReadLine());

int[,] arrayА = GetArray(rowsA, columnsA, 1, 9);
PrintArray(arrayА);

Console.Write("Введите количество строк второго массива: ");
int rowsB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов второго массива: ");
int columnsB = Convert.ToInt32(Console.ReadLine());

int[,] arrayB = GetArray(rowsB, columnsB, 0, 9);
PrintArray(arrayB);

int[,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return arrayC;
}
Console.WriteLine("----------");
PrintArray(GetMultiplicationMatrix(arrayА, arrayB));

// Ваша программа:

Console.Write("Введите количество строк 1 массива: ");
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 1 массива: ");
int columnsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк 2 массива: ");
int rowsB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 2 массива: ");
int columnsB = Convert.ToInt32(Console.ReadLine());
if (columnsA != rowsB)
{
    Console.WriteLine("Такие матрицы умножать нельзя!");
    return;
}
int[,] A = GetArray(rowsA, columnsA, 0, 10);
int[,] B = GetArray(rowsB, columnsB, 0, 10);
PrintArray(A);
Console.WriteLine();
PrintArray(B);
Console.WriteLine();
PrintArray(GetMultiplicationMatrix(A, B));

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
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

int[,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return arrayC;
}
*/