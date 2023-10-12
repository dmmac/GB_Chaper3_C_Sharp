/* 
    Task: For the given N and M calculate sum for all integer numbers between N and M.
    Examples:
        M = 1; N = 15 -> 120
        M = 4; N = 8  -> 30
*/

// Method writes prompt provided as a message parameter and read int from the colsole
int InputInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()??"0");
}

// For the given N and M method calculates sum for all integer numbers between N and M.
int CalculateSumNM(int m, int n)
{
    if (m == n) {
        return m;
    } 
    else 
    {
        return m + CalculateSumNM(m+1, n);
    }
}

int m = InputInt("Please enter m number: ");
int n = InputInt("Please enter n number: ");


Console.WriteLine(m < n ? CalculateSumNM(m,n) : CalculateSumNM(n,m));