//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число ");
Int64 number = Convert.ToInt64(Console.ReadLine());
int FindDigitByPosition(Int64 number, int position)
{
    number = Math.Abs(number);
    int digitCount = (int)Math.Log10((number)) + 1;
    int digitByPosition = -1;
    if (digitCount >= position)
    {
        double extradigits = Math.Pow(10, (digitCount - position));
        digitByPosition = Convert.ToInt32(Math.Floor((number) / extradigits % 10));

    }
    return digitByPosition;
}
int DigitByPosition = FindDigitByPosition(number, 3);

    if(DigitByPosition == -1)
{
        Console.Write("такого числа нет");
}
    else
{
        Console.Write(DigitByPosition);
}
