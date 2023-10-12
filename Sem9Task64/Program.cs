/* 
    Task: for the given N output all integer numbers from N to 1 using recursion.
    Example:
        N = 5 -> "5, 4, 3, 2, 1"
        N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

// Method writes prompt provided as a message parameter and read int from the colsole
int InputInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()??"0");
}

// For the given n method generates string for all integer numbers between n and 1 
string GenerateNumbers(int n)
{
    if (n > 1) {
        return n + ", " + GenerateNumbers(n-1);
    } 
    else 
    {
        return n.ToString();
    } 
}

int n = InputInt("Please enter n number: ");
Console.WriteLine(GenerateNumbers(n));