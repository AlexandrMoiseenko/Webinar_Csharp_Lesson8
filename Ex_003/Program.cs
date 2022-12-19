// Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.

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

int[,] ResultArray(int[,] firstMatrix, int[,] secondMatrix, int n, int m)
{
    int[,] resultMatrix = new int[m,n];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
        {
            resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
        }
        }
    }
    return resultMatrix;
}

int m = Promt("Введите количество строк в массиве: ");
int n = Promt("Введите количество столбцов в массиве: ");
int[,] firstMatrix = new int[m,n];
int[,] secondMatrix = new int[m,n];
PrintArray(CreateArray(firstMatrix, m, n));
Console.WriteLine();
PrintArray(CreateArray(secondMatrix, m, n));
Console.WriteLine();
PrintArray(ResultArray(firstMatrix, secondMatrix, m,n));