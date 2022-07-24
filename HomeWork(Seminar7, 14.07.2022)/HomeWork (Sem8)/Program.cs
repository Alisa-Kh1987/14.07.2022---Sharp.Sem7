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
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк массива: ");
int rows=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns=Convert.ToInt32(Console.ReadLine());
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
    PrintArray (inArray);
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
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов первого массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, 1, 9);
PrintArray(array);

int[,] GetArray2(int m, int n, int minValue, int maxValue)
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

void PrintArray2(int[,] inArray2)
{
    for (int row = 0; row < inArray2.GetLength(0); row++)
    {
        for (int column = 0; column < inArray2.GetLength(1); column++)
        {
            Console.Write($"{inArray2[row, column]}     ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк второго массива: ");
int rows2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов второго массива: ");
int columns2 = Convert.ToInt32(Console.ReadLine());

int[,] array2 = GetArray2(rows2, columns2, 0, 9);
PrintArray2(array2);

void GetMultiplicationMatrix(int[,] array, int[,] array2)
{
    if (rows != columns2)
    {
        Console.WriteLine("Матрицы умножать нельзя");
    }

    int[,] array3 = new int[array.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            //k - отвечает за количество столбцов (*на разборе ДЗ упомянуто строк) первого массива
            for (int k = 0; k < array.GetLength(1); k++)
            {
                array3[i, j] = array[i, k] * array2[k, j];
            }
        }
    }
    PrintArray(array3);
}

GetMultiplicationMatrix(array, array2);
*/