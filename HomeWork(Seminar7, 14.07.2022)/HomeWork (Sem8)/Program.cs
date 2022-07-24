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
*/

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
