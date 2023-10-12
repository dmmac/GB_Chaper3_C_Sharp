int InputInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()??"0");
}

int AkkermanFunction(int n, int m)
{
    if (n == 0) 
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return AkkermanFunction(n - 1, 1);
    } 
    else
    {
        return AkkermanFunction(n-1, AkkermanFunction(n, m-1));
    }
}

int n = InputInt("Please enter n number: ");
int m = InputInt("Please enter m number: ");

Console.WriteLine(AkkermanFunction(n,m));