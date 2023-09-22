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

void ReplaceRowsToColumns(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }
    }
}

bool IsSquareMatrix(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
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
if (!IsSquareMatrix(matrix))
{
    Console.WriteLine("Невозможно заменить строки на столбцы");
    return;
}
ReplaceRowsToColumns(matrix);
Console.WriteLine();
PrintArray(matrix);