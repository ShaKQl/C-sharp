// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int[,] CreateRandIntMatrix(int rows, int columns, int min, int max)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(min, max);
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
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine(" |");
    }
}

int[] MatrixEachColumnMean(int[,] matrix)
{
    int[] columnSumColumn = new int[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        columnSumColumn[j] = sum;
    }
    return columnSumColumn;
}

void PrintFinalResult(int[] arr, int[,] matrx)
{
    Console.WriteLine(" ");
    Console.WriteLine(" ");

    Console.Write($" Среднее арифметическое каждого столбца ");

    for (int i = 0; i < arr.Length; i++)
    {
        double toDouble = Convert.ToDouble(arr[i]) / matrx.GetLength(1);
        Console.Write(i == matrx.GetLength(1) - 1 ? $" {toDouble}. " : $" {toDouble};");
    }
}


int[,] matrix = CreateRandIntMatrix(6, 4, 0, 10);
int[] array = MatrixEachColumnMean(matrix);
PrintMatrix(matrix);
PrintFinalResult(array, matrix);