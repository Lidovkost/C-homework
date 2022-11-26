// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
int weekDay = 0;
int prompt(string message)
{
    Console.Write(message);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
while (weekDay >= 8 | weekDay < 1)
{
    weekDay = prompt("Введите число от 1 до 7 ");
}
if (weekDay > 5)
{
    Console.Write("yes");
}
else
{
    Console.Write("no");
}
