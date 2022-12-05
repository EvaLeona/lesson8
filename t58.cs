using MyLib;

int[,] MatrixMultiplication(int[,] A, int[,] B)
{ 
    int rowsA = A.GetLength(0);
    int colsA = A.GetLength(1);
    int rowsB = B.GetLength(0);
    int colsB = B.GetLength(1);
    if (rowsA != rowsB)
    {
        throw new ArgumentException("число строк в матрицах не равно\n" +
                                    "произведение выполнить невозможнo\n\n");
    }

    int rowsC = rowsA;

    int colsC = colsB;
   
    int[,] C = new int[rowsC, colsC];

    for (int i = 0; i < rowsC; i++)
    {
        for (int j = 0; j < colsC; j++)
        { // C[i,j]
            C[i, j] = 0;
            for (int k = 0; k < rowsB; k++)
            {
                C[i, j] += A[i, k] * B[k, j];
            }
        }
    }
    return C;
}


int[,] matrixA = Function.GetArray(2, 2, 1, 9);
int[,] matrixB = Function.GetArray(2, 2, 1, 9);

Function.PrintArray(matrixA);
Console.WriteLine(" - - - - - - ");
Function.PrintArray(matrixB);
Console.WriteLine(" - - - - - - ");
int[,] matrixC = MatrixMultiplication(matrixA, matrixB);
Function.PrintArray(matrixC);


