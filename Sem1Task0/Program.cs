
// Write prompt for the user input
Console.WriteLine("Введите число: ");

// Read input from the console
string? inputNum = Console.ReadLine();

// check that input is not empty
if (inputNum != null) 
{
    // parse user input
    int num = int.Parse(inputNum);

    // calculate squre for the number
    int result = num * num;

    // print result
    Console.WriteLine(result);
}