Console.WriteLine("Enter a number ");
int num = Convert.ToInt32(Console.Read());
int par = num % 2;

if(par == 0) Console.WriteLine("The number is even");
if(par == 1) Console.WriteLine("The number is odd");