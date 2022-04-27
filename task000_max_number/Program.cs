Console.WriteLine("Enter first number ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number ");
int secondNum = Convert.ToInt32(Console.ReadLine());

int max = firstNum;
if(secondNum > max) max = secondNum;

Console.Write(max);
Console.WriteLine(" is bigger");