//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
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
int evenNumbers(int[] array)
{
    int evenNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) evenNumbers = evenNumbers + 1;
    }
    return evenNumbers;
}
int numberOfEvenNumbers = evenNumbers(testArray);
printArray(testArray);
Console.WriteLine();
Console.WriteLine(numberOfEvenNumbers);


// без метода
// int arraylength = testArray.Length;
// int evenNumbers = 0;
//     for(int i = 0; i < testArray.Length; i++ )
//     {
//         if(testArray[i]%2==0) evenNumbers = evenNumbers +1;
//     }    
// printArray(testArray);
// Console.WriteLine();
// Console.WriteLine(evenNumbers);