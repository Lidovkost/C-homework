//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементоv массива.
double[] createAraay()
{
    Console.WriteLine("введите количество элементов массива");
    int numberOfElements = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[numberOfElements];
    return array;
}
void printArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
void rndArrayElements(double[] array)
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
double[] testArray = createAraay();
rndArrayElements(testArray);
printArray(testArray);
//не знаю в правилах ли задачи:
// double maxminElementDiff = testArray.Max() - testArray.Min();
double MaxElement(double[] array)
{
    double ArrMaxElement = double.MinValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (ArrMaxElement < array[i]) ArrMaxElement = array[i];
    }
    return ArrMaxElement;
}
double MinElement(double[] array)
{
    double ArrMinElement = double.MaxValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (ArrMinElement > array[i]) ArrMinElement = array[i];
    }
    return ArrMinElement;
}
double maxminElementDiff = MaxElement(testArray) - MinElement(testArray);
Console.WriteLine();
Console.WriteLine(maxminElementDiff);