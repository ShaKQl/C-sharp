// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


int[,] CreateArrayRandInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|    ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine("    |");
    }
}




void PrintSameIndexValuesSquared(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("|    ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                Console.Write($"{arr[i, j] * arr[i, j],6}/");
            }
            else Console.Write($" {arr[i, j],6}");
        }
        Console.WriteLine("    |");
    }
}

Console.WriteLine($" ");
Console.WriteLine($" ");
int[,] matrix = CreateArrayRandInt(4, 5, -20, 20);
PrintMatrix(matrix);

Console.WriteLine($" ");
Console.WriteLine($"{'|',20}");
Console.WriteLine($"{'|',20}");
Console.WriteLine($"{'V',20}");
Console.WriteLine($" ");

PrintSameIndexValuesSquared(matrix);
Console.WriteLine($" ");
Console.WriteLine($" ");