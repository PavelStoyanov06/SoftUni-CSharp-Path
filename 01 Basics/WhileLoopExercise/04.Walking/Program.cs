const int GOAL = 10000;

int walked = 0;

string input = Console.ReadLine();

while(walked < GOAL)
{
    if(input == "Going home")
    {
        int steps = int.Parse(Console.ReadLine());
        walked += steps;
        break;
    }
    else
    {
        int steps = int.Parse(input);
        walked += steps;
    }
    input = Console.ReadLine();
}

if(walked >= GOAL)
{
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{walked - GOAL} steps over the goal!");
}
else
{
    Console.WriteLine($"{GOAL - walked} more steps to reach goal.");
}