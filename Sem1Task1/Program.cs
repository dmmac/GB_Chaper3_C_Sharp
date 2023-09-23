Console.Write("Enter first number: ");
int numA = int.Parse(Console.ReadLine()??"0");

Console.Write("Enter second number: ");
int numB = int.Parse(Console.ReadLine()??"0");

if (numA == numB * numB) 
{
    Console.WriteLine("First number is a squre of second number");
}
else
{
    Console.WriteLine("First number is NOT a squre of second number");
}