Console.Write("Enter first number: ");

int firstNumber = int.Parse(Console.ReadLine()??"0");

Console.Write("Enter second number: ");

int secondNumber = int.Parse(Console.ReadLine()??"0");

Console.WriteLine($"a={firstNumber}; b={secondNumber} -> Max={Math.Max(firstNumber, secondNumber)}");