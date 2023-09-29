Console.Write("Enter the number: ");

int n = int.Parse(Console.ReadLine()??"0");

Console.Write($"{n} -> ");

for (int i = 2; i <= n; i += 2) 
{
    Console.Write(i);
    if (i < n-1)
    {
        Console.Write(", ");
    }
}