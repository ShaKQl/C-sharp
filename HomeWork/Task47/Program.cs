
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


double[,] CreateRandDoubleMatrix(int rows, int columns, double min, double max)
{
    Random rand = new Random();
    double[,] matrix = new double[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           matrix[i, j] = Math.Round((rand.NextDouble() * (max - min + 1) + min), 1) ;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 6}");
        }
        Console.WriteLine(" |");
    }
}

double[,] matrix = CreateRandDoubleMatrix(3, 4, -10, 10);
PrintMatrix(matrix);