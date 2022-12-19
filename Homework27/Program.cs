//  Напишите программу, которая заполнит спирально массив 4 на 4.
int[,] CreateMatrix()
{
    Console.WriteLine("Введеите количество строк в массиве");
    int raw = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введеите количество столбцов в массиве");
    int column = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[raw, column];
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    const int cellWidth = 4;
    int maxRow = matrix.GetLength(0);
    int maxCol = matrix.GetLength(1);
    for (int row = 0; row < maxRow; row++)
    {
        for (int col = 0; col < maxCol; col++)
        {
            Console.Write($"{matrix[row, col],cellWidth}");
        }
        Console.WriteLine();
    }
}
void FillSpirallyArray(int[,] matrix)
{
    int number = 1;
    int maxRow = matrix.GetLength(0);
    int maxCol = matrix.GetLength(1);
    int minRow = 1;
    int minCol = 0;
    int row = 0;
    int col = 0;
    while (number <= matrix.GetLongLength(0) * matrix.GetLongLength(1))
    {    
        while (col < maxCol)
        {
            matrix[row, col] = number;
            number= number +1;
            col= col+1;
        }
        row = row + 1;
        col = col - 1;
        while (row < maxRow)
        {
            matrix[row, col] = number;
            number = number + 1;
            row = row + 1;
        }
        col = col - 1;
        row = row - 1;
        while (col >= minCol)
        {
            matrix[row, col] = number;
            number = number + 1;
            col = col - 1; ;
        }
        col = col + 1;
        row = row - 1;
        while (row >= minRow)
        {
            matrix[row, col] = number;
            number = number + 1;
            row=row-1;
        }
        row = row + 1;
        col = col + 1;
        maxRow = maxRow - 1;
        minRow = minRow + 1;
        minCol = minCol + 1;
        maxCol = maxCol - 1;   
    }        
}
int[,] matrix = CreateMatrix();
FillSpirallyArray(matrix);
Console.WriteLine("result:");
PrintMatrix(matrix);