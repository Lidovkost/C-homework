﻿//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число ->");
double number = Convert.ToDouble(Console.ReadLine());
if(number%2 == 0)                                      //после условия ; не нужна!
{
Console.WriteLine($"Число {number} является четным");
}
else                                                      
{
Console.WriteLine($"Число {number} не является четным");    
}