// Задача. Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до (N)

Console.WriteLine("Enter the number ");
int num = Convert.ToInt32(Console.ReadLine());

if(num == 0) Console.WriteLine(num);
else if(num < 0) Console.WriteLine("Error. The number is negative!");
else
{
    Console.Write("Even range is: ");

for(int i = 1; i <= num; i++)
{
    if(i % 2 == 0)
    {
        Console.Write(i);

        if(i <= num - 2)
        {
            Console.Write(", ");
        }   
    }    
}
}

Console.ReadLine();