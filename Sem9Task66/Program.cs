int InputInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()??"0");
}

int CalculateSumNM(int m, int n)
{
    if (m==n) {
        return m;
    } 
    else 
    {
        return m + CalculateSumNM(m+1, n);
    }
}

int m = InputInt("Please enter m number: ");
int n = InputInt("Please enter n number: ");


Console.WriteLine( m<n ? CalculateSumNM(m,n) : CalculateSumNM(n,m));