// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


void MatrixFill (int[,] matrix) 
{ 
    Random rand = new Random(); 
    for (int i = 0 ; i < matrix.GetLength(0); i++) 
    { 
        for (int j = 0 ; j < matrix.GetLength(1);j++) 
        { 
            matrix[i, j] = rand.Next(1,15); 
        } 
    } 
} 
void MatrixPrint (int[,] matrix) 
{ 
    for (int i = 0 ; i < matrix.GetLength(0);i++) 
    { 
        for (int j = 0 ; j < matrix.GetLength(1);j++) 
        { 
            Console.Write($"{matrix[i, j],5}"); 
        } 
        Console.WriteLine(); 
    } 
} 
int FindMaxIndex(int[,] matrix,int indexСolumn, int indexString) 
{ 
    int maxDigit = 0; 
    int maxIndex = 0; 
    for (int j = indexСolumn ;j < matrix.GetLength(1);j++) 
    { 
        if (maxDigit < matrix[indexString,j]) 
        { 
            maxDigit = matrix[indexString,j]; 
            maxIndex = j; 
        } 
    } 
    return maxIndex; 
} 
 
void MatrixSortByString(int[,] matrix) 
{ 
    int minDigitIndex = 0; 
    for (int i = 0 ; i < matrix.GetLength(0);i++){ 
        for (int j = 0 ; j < matrix.GetLength(1);j++) 
        { 
            minDigitIndex = FindMaxIndex(matrix,j,i); 
            int temp = matrix[i,j]; 
            matrix[i,j] = matrix[i,minDigitIndex]; 
            matrix[i,minDigitIndex] = temp; 
        } 
    } 
} 

int[,] matrix = new int[4,4]; 
MatrixFill(matrix); 
MatrixPrint(matrix); 
Console.WriteLine(); 
MatrixSortByString(matrix); 
MatrixPrint(matrix);