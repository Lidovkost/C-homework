//Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
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
    int k = Convert.ToInt32(Console.ReadLine()) + 1;
    for (int row = 0; row < maxRow; row++)
    {
        for (int col = 0; col < maxCol; col++)
        {
            matrix[row, col] = rnd.Next(n, k);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    int maxRow = matrix.GetLength(0);
    int maxCol = matrix.GetLength(1);
    for (int row = 0; row < maxRow; row++)
    {
        for (int col = 0; col < maxCol; col++)
        {
            Console.Write($"{matrix[row, col]} ");
        }
        Console.WriteLine();
    }
}
String NumberRowWithMinSum(int[,] matrix)
{
    int maxRow = matrix.GetLength(0);
    int maxCol = matrix.GetLength(1);
    int[] array = new int[maxCol];
    int sum1 = int.MaxValue;
    int sum2 = 0;
    int rowNumber = 0;
    for (int i = 0; i < maxRow; i++)
    {
        for (int j = 0; j < maxCol; j++)
        {
            sum2 = sum2 + matrix[i, j];
        }
        if (sum2 < sum1)
        {
            rowNumber = i;
            sum1 = sum2;
        }
        sum2 = 0;
    }
    string numberRowWithMinSum = $"C наименьшей суммой элементов: {rowNumber + 1} строка";
    return numberRowWithMinSum;
}
int[,] matrix = CreateMatrix();
RandomMatrixElements(matrix);
PrintMatrix(matrix);
Console.WriteLine();
string minrow = NumberRowWithMinSum(matrix);
Console.WriteLine(minrow);