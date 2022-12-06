// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
int[] createAraay()
{
    Console.WriteLine("введите количество элементов массива");
    int numberOfElements = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[numberOfElements];
    return array;
}
void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
void rndArrayElements(int[] array)
{
    Random rnd = new Random();
    Console.WriteLine("Введите минимальный порог случайных значений");
    int minrnd = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальный порог случайных значений");
    int maxrnd = Convert.ToInt32(Console.ReadLine()) + 1;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minrnd, maxrnd);
    }

}
int[] testArray = createAraay();
rndArrayElements(testArray);
printArray(testArray);
int SumOfelEmentsOfOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}
int sum = SumOfelEmentsOfOddPositions(testArray);
Console.WriteLine();
Console.WriteLine(sum);
