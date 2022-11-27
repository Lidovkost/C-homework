//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Int64 index = 0;
Int64 prompt(string message)
{
    Console.Write(message);
    Int64 answer = Convert.ToInt64(Console.ReadLine());
    return answer;
}
Int64 number = prompt("Введите число ");
Int64[] arrayOfNumbers = new Int64[number];
if (number < 1)
{
    Console.Write("Введеное число меньше 1");
}
else
{
    while (index < number)
    {
        arrayOfNumbers[index] = Convert.ToInt64(Math.Pow((index+1), 3));
        index++;
    }
}
var str = string.Join(" ", arrayOfNumbers);
Console.WriteLine(str);