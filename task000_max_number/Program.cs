// Задача. Напишите программу, которая принимает на вход 2 числа
// и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Enter first number ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number ");
int secondNum = Convert.ToInt32(Console.ReadLine());

if(firstNum > secondNum)
{
    Console.WriteLine(firstNum + " is bigger then " + secondNum);
}

if(secondNum > firstNum)
{
    Console.WriteLine(secondNum + " is bigger then " + firstNum);
}

if(firstNum == secondNum)
{
    Console.WriteLine("Numbers are equal");
}