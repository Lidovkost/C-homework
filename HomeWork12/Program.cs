// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе. Реализовать через функции.
int sumOfNumbers(int number)
{
    if (number < 0)
    {
        number = number * -1;
    }
    int sumOfNumbers = 0;
    int a = 1;
    if (number % 10 == number)
    {
        sumOfNumbers = number % 10;
    }
    else
    {
        while (number % a < number)
        {
            sumOfNumbers = sumOfNumbers + number / a % 10;
            a = a * 10;
        }
    }

    return sumOfNumbers;
}
Console.WriteLine("Введите число");
int c = Convert.ToInt32(Console.ReadLine());
int b = sumOfNumbers(c);
Console.WriteLine($"Сумма чисел в числе {c} = {b}");
