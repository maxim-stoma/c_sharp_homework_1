// Задача. Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

Console.WriteLine("Enter first number ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number ");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number ");
int thirdNum = Convert.ToInt32(Console.ReadLine());
int max = firstNum;


if (firstNum > max) max = firstNum;
if (secondNum > max) max = secondNum;
if (thirdNum > max) max = thirdNum;

Console.Write("The largest number of three is ");
Console.WriteLine(max);