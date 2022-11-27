// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int prompt(string message)
{
    Console.Write(message);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
int number = prompt("Введите пятизначное число ");
int specificDigit(int number, int numberLenght, int digitNumber)
{
number = number / Convert.ToInt32(Math.Pow(10, (numberLenght - digitNumber))) % 10;
return number;
}

while (Math.Abs(number) < 10000 | Math.Abs(number) > 99999)
{
    number = prompt("Введеное вами число не пятизначное, введите пятизначное число ");
}

int firstDigit = specificDigit(number, 5, 1);
int secondDigit = specificDigit(number, 5, 2);
int fourthDigit = specificDigit(number, 5, 4);
int fifthDigit = specificDigit(number, 5, 5);
if(firstDigit == fifthDigit & secondDigit == fourthDigit)
{
    Console.Write($"Число {number}  является палиндромом ");
}
else
{
    Console.Write($"Число {number} не  является палиндромом ");
}

