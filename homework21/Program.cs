//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] CreateMatrix()
{
    Console.WriteLine("Введеите количество строк в массиве");
    int raw = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введеите количество столбцов в массиве");
    int column = Convert.ToInt32(Console.ReadLine());
    double[,] matrix = new double[raw, column];
    return matrix;
}
void RandomMatrixElements(double[,] Matrix)
{
    int MaxRow = Matrix.GetLength(0);
    int MaxCol = Matrix.GetLength(1);
    Random rnd = new Random();
    Console.WriteLine("Введеите минимальное значение элементов массива");
    double n = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введеите максимальное значение элементов массива");
    double k = Convert.ToDouble(Console.ReadLine())+1;
    for(int row = 0; row<MaxRow; row++)
    {
        for(int col = 0; col<MaxCol; col++)
        {
            Matrix[row, col] = n+rnd.NextDouble()*k;
        }
    }
}
void PrintMatrix(double[,] Matrix)
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

double[,] Matrix = CreateMatrix();
RandomMatrixElements(Matrix);
PrintMatrix(Matrix);
