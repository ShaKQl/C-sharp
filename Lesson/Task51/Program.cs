
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int[,] CreateArrayRandInt(int rows, int columns, int max, int min)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(max, min);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 6}");
        }
        Console.WriteLine("  |");
    }
    Console.WriteLine(" ");
    Console.WriteLine(" ");

    int result = MatrixDiagonalSum(matrix);
    Console.WriteLine($"Сумма элементов главной диагонали : {result}");
}

int MatrixDiagonalSum(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sum += matrix[i, j];
        }
    }
    return sum;
}


int[,] matrix = CreateArrayRandInt(3, 4, -20, 20);
PrintMatrix(matrix);
