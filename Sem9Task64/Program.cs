int InputInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()??"0");
}

string GenerateNumbers(int n)
{
    if (n > 1) {
        return n + ", " + GenerateNumbers(n-1);
    } 
    else if (n==1) 
    {
        return n.ToString();
    } 
    else 
    {
        return "";
    }
}

int n = InputInt("Please enter n number: ");
Console.WriteLine(GenerateNumbers(n));