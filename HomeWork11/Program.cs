//  Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. Реализовать через функции.
int exponentation(int a, int b)
{
     int product = 1;
    for(int i = 1; i <= b; i++)
    {
      
       product = product * a;
       
    }
    return product; 

}
int productq = exponentation(7, 2);
Console.WriteLine(productq);