// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
double number;
int NumberofNumbers = 0;
string input = " ";
bool isNumber = double.TryParse(input, out number);
while(input.ToLower() != "end")
{
    Console.WriteLine("Введите число или \"End\" если хотите прервать ввод");
    input = Console.ReadLine();
    input = input.Replace('.', ',');
    isNumber = double.TryParse(input, out number);
    if (isNumber)
    {
        number = Convert.ToDouble(input);
        if(number>0) NumberofNumbers = NumberofNumbers+1;
    }
else if(input.ToLower()!="end")
{
    Console.WriteLine("Вы ввели не число, если хотите ввести число введите \"end\"");
}
}
Console.WriteLine($"Количество введеных чисел больше нуля = {NumberofNumbers}");
