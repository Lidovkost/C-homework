//Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.
int number = 0;

while (number > 999 | number < 100)
{
    Console.Write("Введите трехзначное число ->");
    number = Convert.ToInt32(Console.ReadLine());
    number = Math.Abs(number);
}

int digit = number / 10 % 10;
Console.WriteLine(digit);





