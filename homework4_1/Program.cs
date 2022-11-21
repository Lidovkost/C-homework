// See https://aka.ms/new-console-template for more information
Console.Write("Введите N ->");                  
Int32 N = Convert.ToInt32(Console.ReadLine());  // вводим наше N
Int32 index = 0;                                //index - номер элемента массива
Int32 [] numbers = new Int32[N/2];              // создаем массив с количеством элементов N/2
Int32 count=0;
while(count<=N)                                 //повторяем пока count<=N
{
    if(count%2==0)                              
    {
        numbers[index] = N;                     //когда число четное записываем его в текущий элемент массива
        index+=1;                               //когда число было четным, переходим на следующий элемент массива
    }
    count++;                                    
}
for (index = 0; index < numbers.Length; index++)
{
    Console.Write(numbers[index]);                   // выводим массив
}
