// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
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
string FindMatrixElement(int[,] matrix)
{
    int maxRow = matrix.GetLength(0);
    int maxCol = matrix.GetLength(1);
    Console.WriteLine("Введеите ряд");
    int row = Convert.ToInt32(Console.ReadLine())-1;
    Console.WriteLine("Введеите столбец");
    int col = Convert.ToInt32(Console.ReadLine())-1;
    string desiredElement;
    if(row>=maxRow || col>=maxCol || row<0 || col<0) 
    {
        desiredElement = "такого числа в массиве нет";
    }
    else 
    {
        desiredElement = Convert.ToString(matrix[row,col]);
    }
    return desiredElement;
}

int[,] matrix = CreateMatrix();
RandomMatrixElements(matrix);
PrintMatrix(matrix);
string desiredElement = FindMatrixElement(matrix);
Console.WriteLine($"Искомый элемент = {desiredElement}");

