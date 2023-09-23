Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine()??"0");

if (number>100 && number<1000) 
{
    Console.WriteLine("Last digit is " + number % 10);
}
else
{
    Console.WriteLine("Provided number does not have three digits");
}