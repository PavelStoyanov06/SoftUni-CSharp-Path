int grades = int.Parse(Console.ReadLine());

string input =  Console.ReadLine();
int badCount = 0;

double total = 0;
int count = 0;
string lastProblem = string.Empty;

while (input != "Enough")
{
    double grade = double.Parse(Console.ReadLine());
    total += grade;
    count++;
    if(grade <= 4)
    {
        badCount++;
    }
    if(badCount == grades)
    {
        Console.WriteLine($"You need a break, {grades} poor grades.");
        Environment.Exit(0);
    }
    lastProblem = input;
    input = Console.ReadLine();
}

Console.WriteLine($"Average score: {total/count:f2}");
Console.WriteLine($"Number of problems: {count}");
Console.WriteLine($"Last problem: {lastProblem}");