//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// double [] numbers = new double[3]; //double - тип элементов массива, numbers - наименование, [3] - количество элементов массива
// Console.WriteLine("Введите первое число");
// numbers[0] = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// numbers[1] = Convert.ToDouble(Console.ReadLine()); 
// Console.WriteLine("Введите третье число");
// numbers[2] = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("максимальное число " + numbers.Max());//функция .max определяет максимальный элемент массива, .min минимальный.
Console.WriteLine("ВВедите первое число");
double firstNumber = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ВВедите второе число");
double secondNumber = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ВВедите третье число");
double thirdNumber = Convert.ToDouble(Console.ReadLine());
double Max = firstNumber;
if (Max < secondNumber) Max = secondNumber;
if (Max < thirdNumber) Max = thirdNumber;
Console.WriteLine($"Максимальное число = {Max}");
