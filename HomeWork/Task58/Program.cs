// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

void MatrixFill(int[,] matrixOne, int[,] matrixTwo)
{
    Random rand = new Random();
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            matrixOne[i, j] = rand.Next(1, 10);
        }
    }

    for (int j = 0; j < matrixTwo.GetLength(1); j++)
    {
        for (int i = 0; i < matrixTwo.GetLength(0); i++)
        {
            matrixTwo[i, j] = rand.Next(1, 10);
        }
    }
}
void MatrixPrint(int[,] matrixOne, int[,] matrixTwo)
{
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            Console.Write($"{matrixOne[i, j],5}");
        }

        Console.Write("     |");

        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            Console.Write($"{matrixTwo[i, j],5}");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiply(int[,] matrix, int rows, int columns)
{
    int[,] matrixFirst = new int[rows, columns];
    int[,] matrixSecond = new int[rows, columns];

    MatrixFill(matrixFirst, matrixSecond);
    MatrixPrint(matrixFirst, matrixSecond);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {

            for (int k = 0; k < rows; k++)
            {
                matrix[i, j] += matrixFirst[i, k] * matrixSecond[k, j];
            }
        }
    }
    return matrix;
}

void PrintMultipliedValues(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

int[,] matrixZero = new int[2, 2];

int[,] matrixFinal = MatrixMultiply(matrixZero, 2, 2);
Console.WriteLine();
PrintMultipliedValues(matrixFinal);



