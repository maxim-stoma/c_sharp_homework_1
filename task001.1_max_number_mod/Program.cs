// Задача. Напишите программу, которая принимает на вход три числа,
// и выдаёт максимальное из этих чисел 

Console.Write("Enter the number of array elements: ");

var n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

for(int i = 0; i < array.Length; i++)
{
    Console.Write($"Enter an array element number {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Displaying array elements: ");

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
    if (i <= array.Length - 2)
    {
        Console.Write(", "); 
    }
}

int max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}

Console.WriteLine("");
Console.WriteLine($"Array element {max} is maximal");

Console.ReadLine();