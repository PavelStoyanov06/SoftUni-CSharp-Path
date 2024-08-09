double required = double.Parse(Console.ReadLine());

double available = double.Parse(Console.ReadLine());

int days = 0;
int timeSpent = 0;

while (available < required)
{
    string command = Console.ReadLine();
    double money = double.Parse(Console.ReadLine());
    days++;
    if (command == "spend")
    {
        timeSpent++;
        if(timeSpent >= 5)
        {
            Console.WriteLine("You can't save the money.");
            Console.WriteLine(days);
            Environment.Exit(0);
        }
        available -= money;
        if(available < 0)
        {
            available = 0;
        }
    }
    else if(command == "save")
    {
        timeSpent = 0;
        available += money;
    }
}

Console.WriteLine($"You saved the money for {days} days.");