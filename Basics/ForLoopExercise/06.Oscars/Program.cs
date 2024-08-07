string nameActor = Console.ReadLine();

double points = double.Parse(Console.ReadLine());

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    double pointAward = double.Parse(Console.ReadLine());
    points += name.Length * pointAward / 2;

    if(points >= 1250.5)
    {
        Console.WriteLine($"Congratulations, {nameActor} got a nominee for leading role with {points:f1}!");
        Environment.Exit(0);
    }
}

Console.WriteLine($"Sorry, {nameActor} you need {1250.5 - points:f1} more!");