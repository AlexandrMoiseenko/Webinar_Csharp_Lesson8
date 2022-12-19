// Задайте двумерный массив. Напишите программу, упорядочивает по 
// убыванию элементы каждой строки двумерного массива.

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

void SortArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)        
        {                                              
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i,k] < matrix[i, k+1])
                {
                    int temp = matrix[i, k+1];
                    matrix[i, k+1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}


int m = Promt("Введите количество строк в массиве: ");
int n = Promt("Введите количество столбцов в массиве: ");
int[,] matrix = new int[m,n];
CreateArray(matrix, m, n);
PrintArray(matrix);
Console.WriteLine();
SortArray(matrix);
PrintArray(matrix);