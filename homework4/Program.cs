// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Введите N ->");
Int32 N = Convert.ToInt32(Console.ReadLine());
Int32 count = 2;
Console.Write("Все четные числа -> ");
while (count <= N)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count} ");
    }
    count += 2;
}
Console.Write("End");
// int[] numbers = new int[4];
// numbers[0]=1;
// numbers[1]=3;
// numbers[2]=7;
// numbers[3]=8;
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.Write(numbers[i]);
// }
