// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

void MatrixFillAndPrint(int[,,] matrix)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rand.Next(10, 99);
                Console.Write($"{matrix[i, j, k] + $"({i},{j},{k})  ",5}");
            }
        }
        Console.WriteLine();
    }
}

int[,,] matrix = new int[2, 2, 2];
MatrixFillAndPrint(matrix);