// Напишите программу, которая из массива случайных чисел.
// Ищет второй максимум (число меньше максимального элемента,
// но больше всех остальных). Сделать одним циклом
// [1, 3, 5, 6, 6, 4] -> 5
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
int MaxElement2(int[] Array)
{
    int maxElement1 = Array[0];
    int MaxElement2 = Array[1];
    for (int i = 0; i < Array.Length; i++)
    {
        if (maxElement1 == Array[i])
        {
            maxElement1 = Array[i];
        }
        else if (maxElement1 < Array[i])
        {
            MaxElement2 = maxElement1;
            maxElement1 = Array[i];
        }
        else if( MaxElement2 < Array[i])
        {
            MaxElement2 = Array[i];
        }
    }
    return MaxElement2;
}
int max2 = MaxElement2(testArray);

Console.WriteLine();
Console.WriteLine(max2);


