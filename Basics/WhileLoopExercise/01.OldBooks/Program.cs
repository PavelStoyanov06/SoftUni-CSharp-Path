string book = Console.ReadLine();

string input = Console.ReadLine();

int count = 0;

while (input != "No More Books")
{
    if(input == book)
    {
        Console.WriteLine($"You checked {count} books and found it.");
        Environment.Exit(0);
    }
    count++;
    input = Console.ReadLine();
}

Console.WriteLine($"The book you search is not here!");
Console.WriteLine($"You checked {count} books.");