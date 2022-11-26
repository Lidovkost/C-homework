// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
int weekDay = 0;
while (weekDay >= 8 | weekDay < 1)
{
    Console.Write("Введите день недели 1-7 ->");
    weekDay = Convert.ToInt32(Console.ReadLine());
}
if (weekDay > 5)
{
    Console.Write("yes");
}
else
{
    Console.Write("no");
}
