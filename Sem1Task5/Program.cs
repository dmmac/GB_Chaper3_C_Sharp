Console.Write("Enter number: ");

int n = int.Parse(Console.ReadLine()??"0");

for (int i = -n; i < n; i++)
{
    Console.Write(i + ", ");
}

Console.WriteLine(n);