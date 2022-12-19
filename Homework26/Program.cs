//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int[,] CreateMatrix()
{
    Console.WriteLine("Введеите количество строк в массиве");
    int raw = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введеите количество столбцов в массиве");
    int column = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[raw, column];
    return matrix;
}
void RandomMatrixElements(int[,] matrix)
{
    int maxRow = matrix.GetLength(0);
    int maxCol = matrix.GetLength(1);
    Random rnd = new Random();
    Console.WriteLine("Введеите минимальное значение элементов массива");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введеите максимальное значение элементов массива");
    int k = Convert.ToInt32(Console.ReadLine())+1;
    for(int row = 0; row<maxRow; row++)
    {
        for(int col = 0; col<maxCol; col++)
        {
            matrix[row, col] = rnd.Next(n, k);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    int maxRow = matrix.GetLength(0);
    int maxCol = matrix.GetLength(1);
    for(int row = 0; row<maxRow; row++)
    {
        for(int col = 0; col<maxCol; col++)
        {
           Console.Write($"{matrix[row, col]} ");
        }
        Console.WriteLine();
    }   
}
int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
{
    int matrix1MaxRow = matrix1.GetLength(0);
    int matrix1MaxCol = matrix1.GetLength(1);
    int matrix2MaxRow = matrix2.GetLength(0);
    int matrix2MaxCol = matrix2.GetLength(1);
    if(matrix1MaxCol!=matrix2MaxRow)
    {
        Console.WriteLine($"произведение матриц не возможно");
        return null;
    }
    int[,] matrixResult = new int[matrix1MaxRow,matrix2MaxCol];    
    for(int i = 0; i<matrix1MaxRow; i++)
    {
        for(int j = 0; j<matrix2MaxCol; j++)
        {
            for(int k = 0; k<matrix2MaxRow; k++)
            {
                matrixResult[i,j] = matrixResult[i,j] + matrix1[i,k]*matrix2[k,j];
            }
        }
             
    }
    return matrixResult;
}
Console.WriteLine("Введите размерность первой матрицы");
int[,] matrix1 = CreateMatrix();
RandomMatrixElements(matrix1);
Console.WriteLine("Введите размерность второй матрицы");
int[,] matrix2 = CreateMatrix();
RandomMatrixElements(matrix2);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
int[,] matrixR = MatrixProduct(matrix1,matrix2);
PrintMatrix(matrixR);


