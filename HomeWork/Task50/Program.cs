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
     
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}");
        }
// 1	4	7	10	13
    }
}

bool CheckUserIndexMatrix(int[,] matrix, int row, int column)
{
    if (matrix.GetLength(1) < row ||
       matrix.GetLength(0) < column)
        return false;

    return true;
}

void PrintFinalResult(int[,] matrix)
{
    Console.Write("Введите строку искомого элемента:    >");
    int rowN = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.Write($"Введите колонку искомого элемента:    {rowN + 1}, >");
    int columnN = Convert.ToInt32(Console.ReadLine()) - 1;

    bool check = CheckUserIndexMatrix(matrix, rowN, columnN);

    Console.WriteLine(" ");
    Console.WriteLine(check ? $"Значение искомого элемента:{matrix[rowN, columnN]} " : "Такого элемента в массиве нет");
    Console.WriteLine(" ");
}


int[,] matrix = CreateRandIntMatrix(3, 4, 0, 10);
Console.WriteLine(" ");

PrintMatrix(matrix);

Console.WriteLine(" ");
Console.WriteLine(" ");

PrintFinalResult(matrix);



 









       