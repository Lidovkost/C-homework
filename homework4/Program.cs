// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Введите N ->");
Int32 N = Convert.ToInt32(Console.ReadLine());
Int32 count=1;
while(count<N)
{
    if(count%2==0)
    {
        Console.Write($"{count} ");
    }
    count++;
}
