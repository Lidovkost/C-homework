// Напишите программу, которая выводит массив из 8 элементов,
// заполненный случайными числами. Оформите заполнение массива 
// и вывод в виде функции (пригодится в следующих задачах).
// Реализовать через функции. (* Доп сложность, “введите количество
// элементов массива”, “Введите минимальный порог случайных значений”,
// “Введите максимальный порог случайных значений”)
int[] createAraay()
{
    Console.WriteLine("введите количество элементов массива");
    int numberOfElements = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[numberOfElements];
    return array;
}
void printArray(int[]array)
{
    for(int i = 0; i<array.Length; i++)
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
    int maxrnd = Convert.ToInt32(Console.ReadLine())+1;
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = rnd.Next(minrnd, maxrnd);
    }
    
}
int[] testArray = createAraay();
rndArrayElements(testArray);
printArray(testArray);


// все что ниже объединяет все вышеиспользованные методы в один
// void PrintArray() // вывод массива со случайными элементами
// {
//     Console.WriteLine("введите количество элементов массива");
//     int numberOfElements = Convert.ToInt32(Console.ReadLine());
//     int[] array = new int[numberOfElements];
//     int arraylength = array.Length;
//     Random rnd = new Random();
//     Console.WriteLine("Введите минимальный порог случайных значений");
//     int minrnd = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите максимальный порог случайных значений");
//     int maxrnd = Convert.ToInt32(Console.ReadLine())+1;
//     for(int i =0; i<arraylength; i++)
//     {
//       array[i] = rnd.Next(minrnd, maxrnd);
//      Console.Write($"{array[i]} ");  
//     }
// }
// PrintArray(); 

