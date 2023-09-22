// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void ReplaceFirstAndLastLists(int[,] arr)
{
    int firstRow = 0;
    int lastRow = arr.GetLength(0) - 1;
    int columns = arr.GetLength(1);

    for (int j = 0; j < columns; j++)
    {
        int temp = arr[firstRow, j];
        arr[firstRow, j] = arr[lastRow, j];
        arr[lastRow, j] = temp;
    }
}

void PrintArray(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrixRndInt(5, 5, 0, 10);
PrintArray(matrix);
ReplaceFirstAndLastLists(matrix);
Console.WriteLine();
PrintArray(matrix);