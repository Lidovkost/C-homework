﻿//Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.
int number = 0;
int prompt(string message)
{
    Console.Write($"Введите число в диапазоне 99<|{message}|<1000 ");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
while (number > 999 | number < 100)
{
    number = prompt("трехзначное число");
    number = Math.Abs(number);
}

int digit = number / 10 % 10;
Console.WriteLine(digit);





