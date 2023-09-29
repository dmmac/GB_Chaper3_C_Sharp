Console.Write("Enter first number: ");

int a = int.Parse(Console.ReadLine()??"0");

Console.Write("Enter second number: ");

int b = int.Parse(Console.ReadLine()??"0");

Console.Write("Enter third number: ");

int c = int.Parse(Console.ReadLine()??"0");

Console.WriteLine($"a={a}; b={b}; c={c} -> Max={Math.Max(Math.Max(a, b), c)}");