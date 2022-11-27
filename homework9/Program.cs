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

firstPoint[index] = prompt("Введите Х первой точки ");
firstPoint[index+1] = prompt("Введите y первой точки ");
firstPoint[index+2] = prompt("Введите z первой точки ");
    
index = 0;
secondPoint[index] = prompt("Введите Х второй точки ");
secondPoint[index+1] = prompt("Введите y второй точки ");
secondPoint[index+2] = prompt("Введите z второй точки ");
index = 0;
while(index <3)
{
    sum = sum + Math.Pow((firstPoint[index] - secondPoint[index]), 2);
    index++;
}
distance = Math.Sqrt(sum);
Console.Write($"Расстояние между точками = {distance} ");

