Console.Write("Enter the number: ");

int a = int.Parse(Console.ReadLine()??"0");

Console.WriteLine($"{a} -> {(a % 2 == 0 ? "Да" : "Нет")}");
