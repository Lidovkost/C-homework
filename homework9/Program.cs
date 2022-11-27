// 
double[] firstPoint = new double[3];
double[] secondPoint = new double[3];
int index = 0;
double sum = 0;
double distance = -1;
double prompt(string message)
{
    Console.Write(message);
    double answer = Convert.ToDouble(Console.ReadLine());
    return answer;
}
while (index < 3)
{
    if (index == 0) firstPoint[index] = prompt("Введите Х первой точки ");
    if (index == 1) firstPoint[index] = prompt("Введите y первой точки ");
    if (index == 2) firstPoint[index] = prompt("Введите z первой точки ");
    index++;
}
index = 0;
while (index < 3)
{
    if (index == 0) secondPoint[index] = prompt("Введите Х второй точки ");
    if (index == 1) secondPoint[index] = prompt("Введите y второй точки ");
    if (index == 2) secondPoint[index] = prompt("Введите z второй точки ");
    index++;
}
index = 0;
while(index <3)
{
    sum = sum + Math.Pow((firstPoint[index] - secondPoint[index]), 2);
    index++;
}
distance = Math.Sqrt(sum);
Console.Write($"Расстояние между точками = {distance} ");

