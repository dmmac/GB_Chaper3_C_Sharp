Console.Write("Enter day number: ");

string[] DAYS_OF_WEEK = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

int dayNumber = int.Parse(Console.ReadLine()??"0");

if(dayNumber <= 7)
{
    Console.WriteLine(DAYS_OF_WEEK[dayNumber-1]);
}
else
{

    Console.WriteLine("Provided number is not day of the week");
}



