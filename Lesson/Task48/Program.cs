// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


int[,] ArrayFillSumTable(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = array[i, j] + j + i;
        }
    }
    return array;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine("      ]");
    }
}

int[,] matrix = ArrayFillSumTable(6, 8);
PrintMatrix(matrix);