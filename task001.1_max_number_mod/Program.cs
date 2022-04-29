// Задача. Напишите программу, которая принимает на вход три числа,
// и выдаёт максимальное из этих чисел 

Console.Write("Enter the number of array elements:\t");

int n = int.Parse(Console.ReadLine());

int[] array = new int[n];

for(int i = 0; i < array.Length; i++)
{
    Console.Write($"Enter an array element number {i}:\t ");
    array[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Displaying array elements: ");

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
    if (i <= array.Length - 2)
    {
        Console.Write(", "); 
    }
}
Console.ReadLine();