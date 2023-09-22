// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


void MatrixFill(int[,] matrix)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(1, 10);
        }
    }
}
void MatrixPrint(int[,] matrix)
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

int FindMaxSumRow(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int column = matrix.GetLength(1);

    int sum = 1000000000;
    int minIndex = 0;

    for (int i = 0; i < row; i++)
    {
        int innerSum = 0;
        for (int j = 0; j < column; j++)
        {
            innerSum += matrix[i, j];
        }

        if (innerSum <= sum)
        {
            sum = innerSum;
            minIndex = i;
        }
    }
    return minIndex;
}

int[,] matrix = new int[4, 4];
MatrixFill(matrix);
MatrixPrint(matrix);
int result = FindMaxSumRow(matrix);
Console.WriteLine($"Row with min sum of row is: {result + 1}");
