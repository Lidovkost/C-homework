//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ackerman(int m, int n)
{

    if (n == 0) return Ackerman(m - 1, 1);
    else if (m > 0 & n > 0) return Ackerman(m - 1, Ackerman(m, n - 1));
    else return n + 1;
}
int c = Ackerman(3, 3);
Console.WriteLine(c);

