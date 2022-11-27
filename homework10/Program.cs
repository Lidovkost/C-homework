//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int index = 1;
int prompt(string message)
{
    Console.Write(message);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
int number = prompt("Введите число ");
if (number < 1)
{
    Console.Write("Введеное число меньше 1");
}
else
{
    while (index <= number)
    {
        Console.Write($"=>{Math.Pow(index, 3)} ");
        index++;
    }
}
