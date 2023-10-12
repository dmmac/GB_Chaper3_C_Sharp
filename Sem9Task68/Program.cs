/* 
    Task: calculate Akkerman function for the given n and m
    Examples:
        m = 2, n = 3 -> A(m,n) = 9
        m = 3, n = 2 -> A(m,n) = 29
*/

// Method writes prompt provided as a message parameter and read int from the colsole
int InputInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()??"0");
}

// Calculates Akkerman function for n and m
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