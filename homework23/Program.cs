// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] CreateMatrix()
{
    Console.WriteLine("Введеите количество строк в массиве");
    int raw = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введеите количество столбцов в массиве");
    int column = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[raw, column];
    return matrix;
}
void RandomMatrixElements(int[,] Matrix)
{
    int MaxRow = Matrix.GetLength(0);
    int MaxCol = Matrix.GetLength(1);
    Random rnd = new Random();
    Console.WriteLine("Введеите минимальное значение элементов массива");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введеите максимальное значение элементов массива");
    int k = Convert.ToInt32(Console.ReadLine())+1;
    for(int row = 0; row<MaxRow; row++)
    {
        for(int col = 0; col<MaxCol; col++)
        {
            Matrix[row, col] = rnd.Next(n, k);
        }
    }
}
void PrintMatrix(int[,] Matrix)
{
    int MaxRow = Matrix.GetLength(0);
    int MaxCol = Matrix.GetLength(1);
    for(int row = 0; row<MaxRow; row++)
    {
        for(int col = 0; col<MaxCol; col++)
        {
           Console.Write($"{Matrix[row, col]} ");
        }
        Console.WriteLine();
    }   
}
double[] ArithmeticMeanOfColumns(int[,]matrix)
{
    int MaxRow = matrix.GetLength(0);
    int MaxCol = matrix.GetLength(1);
    double[] columnsMatrix = new double[MaxCol];
    double sum = 0;
    for(int col = 0; col<MaxCol; col++)
    {
        for(int row = 0; row<MaxRow; row++)
        {
            sum = sum+matrix[row, col];
        }
        columnsMatrix[col] = sum/MaxRow; 
        sum = 0;       
    }
return columnsMatrix;
}
void printArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[,]matrix = CreateMatrix();
RandomMatrixElements(matrix);
PrintMatrix(matrix);
double[] array = ArithmeticMeanOfColumns(matrix);
printArray(array);
