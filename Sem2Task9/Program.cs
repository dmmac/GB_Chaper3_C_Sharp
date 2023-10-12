int number = new Random().Next(10, 100);

int i = number;
int max = 0;

while (i > 0)
{
    max = Math.Max(max, i % 10);
    i /= 10;
}

Console.WriteLine($"{number} -> max={max}");
