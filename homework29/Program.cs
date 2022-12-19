// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
//  в промежутке от M до N с помощью рекурсии.
int NumberSum(int a, int b)
{
    if (a > b) return 0;
    else
    {
        return a + NumberSum(a + 1, b);
    }

}
int c = NumberSum(1, 15);
Console.WriteLine(c);
