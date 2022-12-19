// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
    int k = Convert.ToInt32(Console.ReadLine()) + 1;
    for (int row = 0; row < MaxRow; row++)
    {
        for (int col = 0; col < MaxCol; col++)
        {
            Matrix[row, col] = rnd.Next(n, k);
        }
    }
}
void PrintMatrix(int[,] Matrix)
{
    int MaxRow = Matrix.GetLength(0);
    int MaxCol = Matrix.GetLength(1);
    for (int row = 0; row < MaxRow; row++)
    {
        for (int col = 0; col < MaxCol; col++)
        {
            Console.Write($"{Matrix[row, col]} ");
        }
        Console.WriteLine();
    }
}
void DESCSortMatrixRow(int[,] Matrix)
{
    int MaxRow = Matrix.GetLength(0);
    int MaxCol = Matrix.GetLength(1);
    int[] array = new int[MaxCol];
    for (int i = 0; i < MaxRow; i++)
    {
        for (int j = 0; j < MaxCol; j++)
        {
            array[j] = Matrix[i, j];
        }
        Array.Sort(array);
        for (int k = MaxCol - 1; k >= 0; k--)
        {
            Matrix[i, k] = array[MaxCol - 1 - k];
        }
    }
}
int[,] matrix = CreateMatrix();
RandomMatrixElements(matrix);
PrintMatrix(matrix);
Console.WriteLine();
DESCSortMatrixRow(matrix);
PrintMatrix(matrix);




