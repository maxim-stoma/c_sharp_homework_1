// Задача. Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до (N)

Console.WriteLine("Enter the number ");
int num = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= num; i++)
{
    if(i % 2 == 0)
    {
        Console.Write(i);

        if(i != num)
        {
            Console.Write(",");
        }   
    }    
}