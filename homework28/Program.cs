// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа
// в промежутке от M до N с помощью рекурсии.
void EvenNumbers(int a, int b)
{
    if (a % 2 == 0) Console.WriteLine(a);
    if (a >= b) return;
    EvenNumbers(a + 1, b);
}
EvenNumbers(4, 17);