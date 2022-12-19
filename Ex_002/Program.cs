// Задайте прямоугольный двумерный массив. Напишите программу, которая
// будет находить строку с наименьшей суммой элементов.

int Promt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateArray(int[,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void MinSumElentsArray(int[,] matrix)
{
    int minRow = 0;
    int indexMinSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minRow += matrix[0,i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
        sumRow += matrix[i,j];
        if(sumRow < minRow)
        {
            minRow = sumRow;
            indexMinSumRow = i;
        }
        sumRow = 0;
     } 
    }
     Console.Write($"{indexMinSumRow + 1} строка"); 
}

int m = Promt("Введите количество строк в массиве: ");
int n = Promt("Введите количество столбцов в массиве: ");
int[,] matrix = new int[m,n];
CreateArray(matrix, m,n);
PrintArray(matrix);
Console.WriteLine();
MinSumElentsArray(matrix);