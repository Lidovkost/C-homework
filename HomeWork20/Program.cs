// Найдите максимальное значение в матрице по каждой строке,
//  получите сумму этих максимумов. Затем найдите минимальное
//   значение по каждой колонке,получите сумму этих минимумов.
//    Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
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
int[,] Matrix = CreateMatrix();
int MaxRow = Matrix.GetLength(0);
int MaxCol = Matrix.GetLength(1);
RandomMatrixElements(Matrix);
// PrintMatrix(Matrix);
int max = int.MinValue;
int MaxinRow = 0;
int min = int.MaxValue;
int MininCol = 0;
// int[] RowArray = new int[Row];
// int[] ColArray = new int[Col];
 for(int row = 0; row<MaxRow; row++)
    {
        for(int col = 0; col<MaxCol; col++)
        {
            if(max<Matrix[row, col]) max = Matrix[row, col];
        }
        MaxinRow = max +MaxinRow;
        max = int.MinValue;
    }
    for(int col = 0; col<MaxCol; col++)
    {
        for(int row = 0; row<MaxRow; row++)
        {
            if(min>Matrix[row, col]) min = Matrix[row, col];
        }
        MininCol = min +MininCol;
        min = int.MaxValue;
    }
Console.WriteLine();
Console.WriteLine($"{MaxinRow} - {MininCol} = {MaxinRow-MininCol}");

